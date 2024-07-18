# Pfad zur Eingabedatei
$inputFilePath = "./names"

# Pfad zur Ausgabedatei
$outputFilePath = "./order-of-doom"

# Namen aus der Datei lesen
$names = Get-Content $inputFilePath

# Namen zufällig anordnen
$shuffledNames = $names | Get-Random -Count $names.Count

# Zufällig angeordnete Namen in eine neue Datei schreiben
$shuffledNames | Out-File $outputFilePath

Write-Host "Namen wurden erfolgreich zufällig angeordnet und in $outputFilePath gespeichert."
