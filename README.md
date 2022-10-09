# DesktopCrossplatformSamples

## React electron app

### Необходимые dev dependencies
* Concurrently - необходим для запуска нескольких команд. В данном случае нужно стартануть сам React и после уже Electron
* Wait-on - необходим для ожидания запуска React на порте 3000
* Electron-builder - необходим для сборки под различные ОС, включает также автоматическое обновление приложения из коробки
* Cross-env - необходим для установки переменных окружения одной универсальной командой для всех ОС

## AvaloniaWpf Sample

### Публикация и запуск в релизе
**dotnet publish --configuration Release --runtime ubuntu.20.04-x64 --output publish**

### Запуск без публикации на основе исходников (из директории с .csproj)
**dotnet run**