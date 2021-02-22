
# requires LivingDoc tool. Use:
# dotnet tool install specflow.plus.livingdoc.cli --global
dotnet tool restore

#set for runner/namespace
$testRunner = "xUnit"

#fixed variables
$reportName = "LivingDoc.html"
$featureFolder = "..\Learning." + $testRunner + "Specs"
$testExecutionFile = "..\Learning." + $testRunner + "Specs\bin\Debug\net5.0\TestExecution.json"
$bindingAssembly = "..\Learning." + $testRunner + "Specs\bin\Debug\net5.0\Learning." + $testRunner + "Specs.dll"


#generate Report
# livingdoc feature-folder $featureFolder -t $testExecutionFile --binding-assemblies $bindingAssembly
dotnet livingdoc test-assembly $bindingAssembly -t $testExecutionFile --binding-assemblies $bindingAssembly

#rename generated file
move .\$reportName .\$testRunner-$reportName -Force
explorer.exe .\$testRunner-$reportName
