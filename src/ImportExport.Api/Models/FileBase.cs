using ImportExport.Api.Enums;

namespace ImportExport.Api.Models;

public abstract class FileBase
{
    public string Extension { get; set;  } = string.Empty;
}
