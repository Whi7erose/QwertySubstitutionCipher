# QWERTY Substitution Cipher Tool 🔐

![Version](https://img.shields.io/badge/Version-1.1-blue.svg)
![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey.svg)
![Framework](https://img.shields.io/badge/.NET-8.0_WinForms-512BD4.svg)

A modern, fast, and easy-to-use desktop application built in C# that encrypts and decrypts text using a custom QWERTY keyboard substitution cipher. 

Instead of a standard alphabetical shift (like a Caesar cipher), this tool maps standard alphabetical characters directly to their corresponding visual position on a QWERTY keyboard.

---

## ✨ Features

* **Instant Encryption & Decryption:** Seamlessly translate standard text to cipher text and vice versa.
* **Modern UI/UX:** A sleek, dark-mode flat design using 'Segoe UI' fonts and intuitive color mapping.
* **File Processing:** 
  * **Load `.txt` Files:** Instantly import large blocks of text directly into the application.
  * **Save Output:** Export your encrypted or decrypted results straight to a `.txt` file on your local machine.
* **Smart Input Flow:** A top-to-bottom data flow ensures that the top box is always your input and the bottom box is strictly for your secure output.
* **Read-Only Protection:** The output box allows you to copy text but prevents accidental keystrokes from ruining your cipher.

---

## 🛠️ Technology Stack (What is Used)

* **Language:** C#
* **Framework:** .NET 8.0 (Windows Forms / WinForms)
* **IDE:** Visual Studio 2022
* **CI/CD:** GitHub Actions (Automated `.exe` builds)
* **File Handling:** Native `System.IO`
* **Installer:** Inno Setup (For creating the Windows Setup Wizard)

---

## 🚀 How to Use

### Installation
You do not need to compile the code yourself to use this tool!
1. Go to the **[Actions tab](../../actions)** in this repository.
2. Click on the latest successful workflow run.
3. Scroll down to the **Artifacts** section.
4. Download the `QwertySubstitutionCipher-App` zip file.
5. Extract the folder and double-click `QwertySubstitutionCipher.exe` to run the app.

*(Alternatively, if you were provided the `QwertyCipher_Installer.exe`, simply double-click it to run the Windows Setup Wizard).*

### Basic Usage
1. **To Encrypt:** Type or paste your normal text into the **Input Text** (top) box and click **[ ENCRYPT ]**.
2. **To Decrypt:** Paste your secret cipher text into the **Input Text** (top) box and click **[ DECRYPT ]**.
3. **Using Files:** Use the **[ LOAD .TXT FILE ]** button to read a text file from your computer. Once processed, use the **[ SAVE OUTPUT ]** button to save the bottom box as a new file.
4. Click **[ CLEAR ]** to reset the dashboard.

---

## 🔄 Version History & Changelog

### v1.1 (Current Version) - Major UI & Feature Update
* **UI Overhaul:** Replaced the legacy console-style aesthetic with a modern, dark-themed flat design.
* **File I/O Integration:** Added ability to upload `.txt` files to the input and download the output as a `.txt` file.
* **Logic Fix:** Standardized the workflow so both Encrypt and Decrypt read from the top input box and output to the bottom box.
* **Safety Features:** Made the output box read-only to prevent accidental data corruption.
* **Automation:** Added GitHub Actions `.yml` workflow for automated CI/CD `.exe` artifact generation.

### v1.0 - Initial Release
* Core encryption and decryption logic mapped to the QWERTY layout.
* Basic Windows Forms GUI implementation.

---

## 👨‍💻 Contributing
Feel free to fork this project, submit pull requests, or open issues if you find any bugs or have feature requests!
