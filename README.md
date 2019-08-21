# POC-UploadStream

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/45324253143240acb6e63acc42b110db)](https://app.codacy.com/app/guilherme_9/POC-UploadStream?utm_source=github.com&utm_medium=referral&utm_content=guibranco/POC-UploadStream&utm_campaign=Badge_Grade_Dashboard)

**Proof of Concept** *(POC)* of a upload stream (multipart form data) from **React** app to **C# .NET Core** backend


This POC is based on a .NET Core API & React project.
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