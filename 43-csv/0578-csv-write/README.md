# 0578 — Write CSV

This lesson uses the **CsvHelper** library to write two rows to CSV. A `CsvWriter` writes the header `["name", "age"]` and the data row `["Alice", "30"]` via `WriteField` / `NextRecord` into a `StringWriter` buffer. Because CsvHelper emits `\r\n` line terminators, the output is normalized to `\n` and the trailing newline is stripped before printing.

## Run

    dotnet run
