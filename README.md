# POC React & .NET UploadStream

🔬 Proof of Concept of an upload stream (multipart form data) from **React JS** and **React Native** app to **C# .NET Core** backend

[![wakatime](https://wakatime.com/badge/github/GuilhermeStracini/POC-react-dotnet-UploadStream.svg)](https://wakatime.com/badge/github/GuilhermeStracini/POC-react-dotnet-UploadStream)
[![Maintainability](https://api.codeclimate.com/v1/badges/d24885c9abbb02ef99a0/maintainability)](https://codeclimate.com/github/GuilhermeStracini/POC-react-dotnet-UploadStream/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/d24885c9abbb02ef99a0/test_coverage)](https://codeclimate.com/github/GuilhermeStracini/POC-react-dotnet-UploadStream/test_coverage)
[![CodeFactor](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-react-dotnet-UploadStream/badge)](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-react-dotnet-UploadStream)
[![GitHub license](https://img.shields.io/github/license/GuilhermeStracini/POC-react-dotnet-UploadStream)](https://github.com/GuilhermeStracini/POC-react-dotnet-UploadStream)
[![GitHub last commit](https://img.shields.io/github/last-commit/GuilhermeStracini/POC-react-dotnet-UploadStream)](https://github.com/GuilhermeStracini/POC-react-dotnet-UploadStream)

This POC is based on a .NET Core API & React JS & React Native mobile app project.

```bash
dotnet new React
```
If you want to build your own project, follow these steps:

```bash

dotnet new React
yarn install
yarn upgrade react-scripts --latest
yarn remove eslint eslint-config-react-app eslint-plugin-flowtype eslint-plugin-import eslint-plugin-js-ally eslint-plugin-react babel-eslint
npm install --save react@16.4.0 react-dom@16.4.0
```

---

## References

The following references was used to build this POC:

- [Creating a File Upload Component with React](https://malcoded.com/posts/react-file-upload/#creating-a-new-react-project)
- [Creating a File Dropzone with React](https://malcoded.com/posts/react-dropzone/)
- [How to use Typescript with the ASP.NET Core 2.x React Project Template](https://jonhilton.net/new-aspnet-core-react-project/)
- [File uploads in ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core/mvc/models/file-uploads?view=aspnetcore-2.2#uploading-large-files-with-streaming)

---

## Run

Just open the solution in Visual Studio and run the project.

A browser instance should open in localhost, navigate to **Upload** tab, select one or more files to upload (drag & drop enabled) and then click on the **Upload** button.

*After the upload, you should click the **Clear** button to send the same file again (some error with id of the files might occour if this action is not done).
