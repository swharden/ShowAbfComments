dotnet build "../src/ShowAbfComments/ShowAbfComments.csproj" --configuration Release
rmdir /s /q "X:\Software\ABF comment inspector"
robocopy "..\src\ShowAbfComments\bin\Release\net8.0-windows" "X:\Software\ABF comment inspector"
pause