# DesktopCrossplatformSamples

## React electron app

#### Инициализация Electron (уже выполнено)
**electronize init**

#### Запуск без сбора bundle (обертка над командой из package.json)
**npm run start**

#### Сборка bundle (обертка над командами из package.json)
**npm run build-windows** - для windows
**npm run build-linux** - для linux

#### Необходимые dev dependencies
* Concurrently - необходим для запуска нескольких команд. В данном случае нужно стартануть сам React и после уже Electron
* Wait-on - необходим для ожидания запуска React на порте 3000
* Electron-builder - необходим для сборки под различные ОС, включает также автоматическое обновление приложения из коробки
* Cross-env - необходим для установки переменных окружения одной универсальной командой для всех ОС

## AvaloniaWpf Sample

#### Публикация и запуск в релизе
**dotnet publish --configuration Release --runtime ubuntu.20.04-x64 --output publish**

**dotnet AvaloniaWpf.dll** (в директории publish)

#### Запуск без публикации на основе исходников (из директории с .csproj)
**dotnet run**

![image](https://user-images.githubusercontent.com/57220464/194752787-b61cef52-2f49-4204-a818-95d4ef3d6ae2.png)

