# TinyGUI

Simple program with visual interface to compress images using TinyJPG/TinyPNG.

<p align="middle">
  <img src="https://i.imgur.com/vkR5DMI.png" width="410" align="middle"/>
  <img src="https://i.imgur.com/oZHmw8O.png" width="410" align="middle"/>
  <img src="https://i.imgur.com/bSrwVcn.png" width="410" align="middle"/>
</p>

# Features
- Supports jpg, png and webp image types.
- Converting multiple images at once.
- Multiple API Key support.
- Shows number of requests made through the API Key.

# Settings
**API Keys** - List of API keys. Get the key on [TinyJPG](https://tinyjpg.com/developers).

**API Parser Threads** - Maximum number of running threads when checking API keys.

**Max Requests Per API** - Maximum number of requests per API. When you add your images it will split them evenly throught your API keys. If your API key is at it's limit (500 images default) it will not be used.

**Compressed Path** - The path where compressed images are saved.
- **Full Path** - All images will be saved into this path.
- **Single Folder** - It creates a folder in the path where the image is located and saves the compressed version there.

**Compressed Name** - The style in which the compressed image will be saved. 
- **{name}** - return original file name.

**Compressing Threads** - Maximum number of running threads when compressing images. (Number of requests running at once)

# Using
[Tinify Unofficial](https://github.com/jshergal/tinify-net-unofficial) - Unoficial fork of Tinify API Client. (Slightly modified)

# License
This software is licensed under the MIT License. [View the license](LICENSE).
