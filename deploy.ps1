#Remove-Item "D:\ProjectOnline\resources\server-core\*"  -Recurse
#Copy-Item -Path ".\vendor\ProjectOnline\*" -Destination "D:\ProjectOnline\resources\server-core\" -Recurse
Copy-Item -Path ".\data\*" -Destination "D:\ProjectOnline\resources\server-core\" -Recurse 
Copy-Item -Path ".\artifacts\*" -Destination "D:\ProjectOnline\resources\server-core\" -Recurse
Remove-Item "D:\ProjectOnline\resources\server-core\CitizenFX.Core.*.dll" -Recurse
Remove-Item "D:\ProjectOnline\resources\server-core\*.pdb" -Recurse