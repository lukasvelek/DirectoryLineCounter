# DirectoryLineCounter
DirectoryLineCounter is a C# utility that I use for getting the line count of my applications. I use it mainly for statistics.

The application allows user to choose a directory in which it will perform the counting operation. It also enables exporting data to `.txt` file.

## Usage
Run the `DirectoryLineCounter.exe` executable file and a window will open up. There are several buttons and fields.

1. Select the directory via the _Select directory_ button. A dialog will open up and there you have to choose the directory.
2. Choose a file suffix to check.
3. Click on _Count_ button and wait until it finishes.
4. You will know the application finished counting when:
    - The counted line count is written to the field right next to _Total lines:_
    - Reset button is enabled

Optional:  
5. If you want to export the result, click on the _Export_ button and choose the destination folder of the exported file and the file name and click on _Save_.  
6. If you want to reset the application to its "initial state" (directory will remain selected), click on the _Reset_ button.

## Release notes
### v1.1.0 (_March 10th 2025_)
- `FolderBrowserDialog` is used instead of manual destination directory input
- _File suffix_ is now selected from a `ComboBox` instead of manual input

### v1.0.0 (_release date unknown_)
Initial version release that is not located here and has been available before the project has been uploaded to GitHub.

## Future plans
- Count all file lines instead of only of those files with certain suffix
- Exporting schema update
- For folders with a lot of files or big files - where the application takes a while to process and count the lines - use a loading mouse cursor or a status label