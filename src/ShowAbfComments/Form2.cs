using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace ShowAbfComments;

public partial class Form2 : Form
{
    private readonly string AbfText;
    private readonly System.Windows.Forms.Timer Timer;

    public Form2(string text)
    {
        InitializeComponent();
        AbfText = text;

        Timer = new() { Interval = 1000 };
        Timer.Tick += (s, e) => PopulateTable(AbfText);
        Timer.Start();
    }

    private void PopulateTable(string text)
    {
        Timer.Stop();

        DataTable dataTable = new();
        dataTable.Columns.Add("Path", typeof(string));
        dataTable.Columns.Add("Protocol", typeof(string));

        dataGridView1.RowHeadersVisible = false;
        dataGridView1.DataSource = dataTable;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        string[] lines = text.Split("\n");

        int abfFileCount = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            Text = $"Analyzing line {i + 1} of {lines.Length}...";
            bool isAbfFile = line.Contains(':') && line.Contains(".abf") && File.Exists(line);

            DataRow dataRow = dataTable.NewRow();
            dataRow.SetField(0, line);

            if (isAbfFile)
            {
                abfFileCount += 1;
                AbfSharp.ABFFIO.ABF abf = new(line);
                int column = 1;
                dataRow.SetField(column++, Path.GetFileNameWithoutExtension(abf.Header.sProtocolPath));
                for (int j = 0; j < abf.Tags.Count; j++)
                {
                    if (dataTable.Columns.Count < (column + 1))
                    {
                        dataTable.Columns.Add($"Comment {j + 1}", typeof(string));
                        dataTable.Columns.Add($"Time {j + 1}", typeof(float));
                    }

                    dataRow.SetField(column++, abf.Tags.Comments[j]);
                    dataRow.SetField(column++, abf.Tags.Times[j] / 60);
                }
            }

            dataTable.Rows.Add(dataRow);
            dataGridView1.Rows[i].DefaultCellStyle.BackColor = isAbfFile ? Color.White : SystemColors.Control;
            dataGridView1.FirstDisplayedScrollingRowIndex = i;
            Application.DoEvents();
        }

        Text = $"Analyzed {abfFileCount} ABF files.";
    }
}
