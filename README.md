# EZSS - Easy Screenshot

EZSS (Easy Screenshot) is a simple application for Windows 10+ that allows you to capture and save screenshots extremely quickly with a single keystroke.

It was developed specifically for users who capture a high volume of window-scope screenshots. Sacrifices the more granular control and editing capabilities of built-in snipping tool in favor of speed and efficiency.

Built with Windows Forms .NET

## Features

- Capture screenshots of the active window or window underneath the mouse
- Set a customizable hotkey
- Choose a target directory to save screenshots.
- Toggle preview of captured screenshots.
- Auto-delete old screenshots.

## Installation

>Install with [ClickOnce](http://htmlpreview.github.io/?https://raw.githubusercontent.com/The-Bush/EZSS/main/published/Publish.html)


>Download installer [setup.exe](published/setup.exe)


>Download and run [single file release](published/singlefilerelease/EZSS.exe) (automatic updates not supported) 

## Build from Source

<details>
<summary>
Click to show
</summary>

1. **Prerequisites:**
   - Visual Studio IDE (2019 or later) with .NET Desktop Development workload installed.
   - .NET Framework SDK 6.0+ installed.

2. **Clone the Repository:**
   - Open a terminal or command prompt.
   - Navigate to your desired directory: 
   ```sh
   cd /path/to/your/directory`
   ```
   - Clone the repository: 
   ```sh
   git clone https://github.com/The-Bush/EZSS.git
   ```

3. **Open the Project:**
   - Launch Visual Studio.
   - Click "File" > "Open" > "Project/Solution".
   - Navigate to the cloned repository directory and select the `.sln` file.

4. **Restore Packages:**
   - In Visual Studio, right-click on the solution in Solution Explorer.
   - Click "Restore NuGet Packages" to fetch required dependencies.

5. **Build Configuration:**
   - Choose the appropriate build configuration (Debug/Release) from the toolbar.

6. **Build the Solution:**
   - Click "Build" > "Build Solution" or press `Ctrl + Shift + B`.

7. **Output:**
   - After successful build, the compiled executable will be available in the output directory. (./bin by default)

8. **Run the App:**
   - Locate the compiled executable.
   - Double-click on it to run your WinForms app.

9. **Publishing (Optional):**
    - Right-click on your project in Solution Explorer.
    - Click "Publish".
    - Follow the wizard to configure publishing settings.
    - Choose deployment method (ClickOnce, self-contained, etc.).
</details>

## Usage

![](https://github.com/The-Bush/EZSS/blob/main/EZSS%20How-To.gif)
1. Run the application (executable).
2. Choose a target directory where your screenshots will be saved.
3. Configure your preferred settings, including hotkey, capture options, and auto-delete settings.
4. Press the configured hotkey to capture a screenshot.
5. Captured screenshots will be saved in the selected target directory.

## Contributing

Contributions are welcome! If you have any improvements or new features to add, feel free to create a pull request.

## License

This project is licensed under the [MIT License](https://www.mit.edu/~amini/LICENSE.md).

---
