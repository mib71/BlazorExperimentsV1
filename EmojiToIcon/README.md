# EmojiToIcon

Turn any emoji into a set of PNG icons.

## What it does

Type an emoji, see a live preview, and download any of the three standard sizes:

| File | Size | Use |
|---|---|---|
| `favicon.png` | 32×32 | Browser tab |
| `icon-192.png` | 192×192 | PWA icon (standard) |
| `icon-512.png` | 512×512 | PWA icon (large) |

## How to run

```bash
cd EmojiToIcon
dotnet run
```

Then open the URL shown in the terminal.

## Notes

- Rendering is done entirely in the browser via the Canvas 2D API.
- No dependencies beyond the standard Blazor WebAssembly template and Bootstrap 5.