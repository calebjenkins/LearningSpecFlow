
#set for runner/namespace
$testRunner = "vsTest"

#fixed variables
$reportName = "LivingDoc.html"
$featureFolder = "..\Learning." + $testRunner + "Specs"
$testExecutionFile = "..\Learning." + $testRunner + "Specs\bin\Debug\net5.0\TestExecution.json"

#generate Report
livingdoc feature-folder $featureFolder -t $testExecutionFile 

#rename generated file
move .\$reportName .\$testRunner-$reportName -Force
explorer.exe .\$testRunner-$reportName