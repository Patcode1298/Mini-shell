# Mini Shell

A small C# console "mini shell" that lets you create, read, edit, delete and list text files and adjust simple console settings.

## Features
- Create/read/edit/delete text files stored in the current folder (within `files\` directory).
- Create nested folder structures using the `createdir` command.
- Navigate between folders using the `go` command.
- Display the current folder path using the `locate` command.
- List all files in the current folder (names shown without extension).
- Settings menu to change console background color and window title.
- Simple built-in commands: `help`, `clear`, `exit`.

## Requirements
- .NET SDK (6.0 or newer recommended)
- Windows (uses Console.BackgroundColor and Windows-style paths)

## Setup
1. Install the .NET SDK: `dotnet --version` should print a version.
2. From the project root (where Program.cs lives) create the data directory:
   - `files\` (the app expects this folder to exist)

## Build & Run
From the project root:

- Build:

  dotnet build

- Run:

  dotnet run

The program shows a prompt; type commands (see below). Use `help` to list commands anytime.

## Commands
- `help` — display available commands
- `create` — create a new file (prompts for filename)
- `read` — display a file's contents (prompts for filename)
- `edit` — replace a file's content (prompts for filename and new content)
- `delete` — delete a file (prompts for filename)
- `list` — list all `.txt` files in the current folder (names without extension)
- `createdir` — create a new folder (prompts for folder name; supports nested paths with `\`, e.g., `folder1\folder2`)
- `go` — navigate into a folder (prompts for folder name)
- `locate` — display the current folder location
- `settings` — open settings menu
  - `color` — change background color (options: `b`, `r`, `g`, `y`, `db`, `dr`, `dg`, `dy`, `d`)
  - `title` — change window title (prompts for title)
  - `exitsettings` — exit settings menu
- `clear` — clear console
- `exit` — exit the program (asks for confirmation)

## Notes & Caveats
- Files are read/written using the default .NET encoding.
- All file and folder operations are relative to the current directory, which starts at `files\`.
- The `go` command allows navigation within the `files` directory structure; folder existence is checked before navigation.
- Use `locate` to view the current folder location.
- Use `createdir` to create nested folder structures (e.g., `createdir subfolder\deepfolder` creates both levels).
- The app uses Windows-style paths (`\`). Ensure the `files` directory exists and the app has permission to access it.
- Color and title changes affect the current console window only; exiting resets colors in code when confirmed.

## Contributing
Small fixes and enhancements are welcome. Open an issue or submit a pull request.

## License
MIT
