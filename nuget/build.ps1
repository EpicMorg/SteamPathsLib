Remove-Item './lib/net48/dummy_file' -Force
Remove-Item './*.nupkg' -Force

& nuget.exe pack ./EpicMorg.SteamPathsLib.nuspec

Copy-Item './dummy_file' -Destination './lib/net48/dummy_file' -Force