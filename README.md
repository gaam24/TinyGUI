# TinyGUI

Simple program with visual interface to compress images using TinyJPG.

<p align="middle">
  <img src="https://i.imgur.com/vkR5DMI.png" width="500" align="middle"/>
  <img src="https://i.imgur.com/oZHmw8O.png" width="500" align="middle"/>
  <img src="https://i.imgur.com/bSrwVcn.png" width="500" align="middle"/>
</p>

# Features
- Multiple API Compressing.
- Multithreading Compressing.
- Distributes images between each API.
- Statistics of compressed images and compressing count per API.

# Settings
**API Parser Threads** - Max threads running to check API keys.

**Max Requests Per API** - How many request is available per API. Above number API will not be counted during compression.

**Compressed Path** - Path where compressed files saves. If is a full path images will save there, if is only a single folder (name), it will create folder in image path and save compressed image there

**Compressed Name** - Style in which the compressed image will be saved. *[Variable {name} return original file name]*

**Compressing Threads** - Max threads (API) running to compress images.
