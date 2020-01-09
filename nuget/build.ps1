Remove-Item './lib/net48/dummy_file' -Force
Remove-Item './lib/net472/dummy_file' -Force
Remove-Item './lib/net462/dummy_file' -Force
Remove-Item './lib/net452/dummy_file' -Force

& nuget.exe pack ./EpicMorg.SteamPathsLib.nuspec

Copy-Item './dummy_file' -Destination './lib/net48/dummy_file' -Force
Copy-Item './dummy_file' -Destination './lib/net472/dummy_file' -Force
Copy-Item './dummy_file' -Destination './lib/net462/dummy_file' -Force
Copy-Item './dummy_file' -Destination './lib/net452/dummy_file' -Force