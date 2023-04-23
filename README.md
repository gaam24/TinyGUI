# TinyGUI

Simple program with visual interface to compress images using TinyJPG/TinyPNG.

<p align="middle">
  <img src="https://i.imgur.com/vkR5DMI.png" width="410" align="middle"/>
  <img src="https://i.imgur.com/oZHmw8O.png" width="410" align="middle"/>
  <img src="https://i.imgur.com/bSrwVcn.png" width="410" align="middle"/>
</p>

# Features
- Multiple API images compressing.
- Multithreading compressing.
- Number of compressed images.
- Number of requests made through the API.

# Settings
**API Parser Threads** - Maximum number of running threads when checking API keys.

**Max Requests Per API** - Maximum number of requests per API. When splitting images, it will add as many images to the API as there are requests left (images are split to each API one at a time). If the API has no more requests it will not be counted when splitting.

**Compressed Path** - The path where compressed images are saved.
- Full Path - All images will be saved to this path.
- Single Folder - It creates a folder in the path where the image is located and saves the compressed version there.

**Compressed Name** - The style in which the compressed image will be saved. *[{name} - return original file name]*

**Compressing Threads** - Maximum number of running threads when compressing images. (Number of requests running at once)

# Using
[Tinify Unofficial](https://github.com/jshergal/tinify-net-unofficial) - Unoficial fork of Tinify API Client used to TinyJPG and TinyPNG. (I modified it slightly)
