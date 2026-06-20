# 0710 — UUID version

This lesson uses the built-in **System.Guid** type to parse a UUID and read its
version number. UUIDs encode their version as a single hex digit: in the
canonical string form it sits at index 14 (the first character of the third
dash-separated group). Parsing `550e8400-e29b-41d4-a716-446655440000` and
reading that character yields `4`, meaning this is a random (v4) UUID.

## Run

    dotnet run
