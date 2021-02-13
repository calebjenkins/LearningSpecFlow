$path = "..\Learning.xUnitSpecs\bin\Debug\net5.0\"
$command = "livingdoc" # test-assembly .\Learning.xUnitSpecs.dll -t TestExecution.json"
$fileName = "LivingDoc.html"
$testResultData = "TestExecution.json"

livingdoc test-assembly $path\\Learning.xUnitSpecs.dll -t $path\\$testResultData

copy $path$fileName .\$fileName
copy $path$testResultData .\$testResultData

explorer.exe $fileName
