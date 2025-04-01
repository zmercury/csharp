 flowchart TD
    A[C#] --> B[C# Compiler]
    C[VB.NET] --> D[VB.NET Compiler]
    E[Other Languages] --> F[Other Compiler]
    B --> G[MSIL <br> (Microsoft Intermediate Language)]
    D --> G
    F --> G
    G --> H[Native Code]
