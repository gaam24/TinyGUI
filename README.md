# TinyGUI

Simple software with visual interface to compress images using [TinyJPG](https://tinyjpg.com/)/[TinyPNG](https://tinypng.com/) engine.

<p align="middle">
  <img src="https://i.imgur.com/UdwfLG9.png" width="410" align="middle"/>
  <img src="https://i.imgur.com/dBG26Uj.png" width="410" align="middle"/>
  <img src="https://i.imgur.com/MvOYOFs.png" width="410" align="middle"/>
</p>

# Features
- Supports jpg, png and webp image types.
- Converting multiple images at once.
- Multiple API Key support.
- Shows number of requests made through the API Key.

## Settings
**API Keys** - List of API keys. Get the key on [TinyJPG](https://tinyjpg.com/developers).

**API Parser Threads** - Maximum number of running threads when checking API keys.

**Max Requests Per API** - Maximum number of requests per API. When you add your images it will split them evenly throught your API keys. If your API key is at it's limit (500 images default) it will not be used.

**Compressed Path** - The path where compressed images will be saved.
- **Full Path** - All images will be saved into this path.
- **Single Folder** - It will create a folder in the path where the image is located and it will save a compressed image there.

**Compressed Name** - Name of compressed image.
- **{name}** - Return original image name.

**Compressing Threads** - Maximum number of running threads when compressing images (Number of requests sended at once).

## Credits
- [Tinify Unofficial](https://github.com/jshergal/tinify-net-unofficial) - Unoficial fork of Tinify API Client. (Slightly modified)
- [Krypton-Toolkit](https://github.com/Krypton-Suite/Standard-Toolkit) - Windows GUI toolkit.

## License
This software is licensed under the MIT License. [View the license](LICENSE).
