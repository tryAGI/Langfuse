
#nullable enable

namespace Langfuse
{
    /// <summary>
    /// The MIME type of the media record
    /// </summary>
    public enum MediaContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividegzip,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividejavascript,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividejson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividemsword,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDivideoctetStream,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividepdf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividertf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndApacheParquet,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndMsExcel,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividex7zCompressed,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividexNdjson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividexTar,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividexYaml,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividexml,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividezip,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideaac,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideflac,
        /// <summary>
        /// 
        /// </summary>
        AudioDividemp3,
        /// <summary>
        /// 
        /// </summary>
        AudioDividemp4,
        /// <summary>
        /// 
        /// </summary>
        AudioDividempeg,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideoga,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideogg,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideopus,
        /// <summary>
        /// 
        /// </summary>
        AudioDividewav,
        /// <summary>
        /// 
        /// </summary>
        AudioDividewebm,
        /// <summary>
        /// 
        /// </summary>
        ImageDivideavif,
        /// <summary>
        /// 
        /// </summary>
        ImageDividebmp,
        /// <summary>
        /// 
        /// </summary>
        ImageDividegif,
        /// <summary>
        /// 
        /// </summary>
        ImageDivideheic,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividepng,
        /// <summary>
        /// 
        /// </summary>
        ImageDividesvgPlusxml,
        /// <summary>
        /// 
        /// </summary>
        ImageDividetiff,
        /// <summary>
        /// 
        /// </summary>
        ImageDividewebp,
        /// <summary>
        /// 
        /// </summary>
        TextDividecss,
        /// <summary>
        /// 
        /// </summary>
        TextDividecsv,
        /// <summary>
        /// 
        /// </summary>
        TextDividehtml,
        /// <summary>
        /// 
        /// </summary>
        TextDividemarkdown,
        /// <summary>
        /// 
        /// </summary>
        TextDivideplain,
        /// <summary>
        /// 
        /// </summary>
        TextDividexPython,
        /// <summary>
        /// 
        /// </summary>
        TextDividexTypescript,
        /// <summary>
        /// 
        /// </summary>
        VideoDividemp4,
        /// <summary>
        /// 
        /// </summary>
        VideoDividempeg,
        /// <summary>
        /// 
        /// </summary>
        VideoDivideogg,
        /// <summary>
        /// 
        /// </summary>
        VideoDividequicktime,
        /// <summary>
        /// 
        /// </summary>
        VideoDividewebm,
        /// <summary>
        /// 
        /// </summary>
        VideoDividexMatroska,
        /// <summary>
        /// 
        /// </summary>
        VideoDividexMsvideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaContentType value)
        {
            return value switch
            {
                MediaContentType.ApplicationDividegzip => "application/gzip",
                MediaContentType.ApplicationDividejavascript => "application/javascript",
                MediaContentType.ApplicationDividejson => "application/json",
                MediaContentType.ApplicationDividemsword => "application/msword",
                MediaContentType.ApplicationDivideoctetStream => "application/octet-stream",
                MediaContentType.ApplicationDividepdf => "application/pdf",
                MediaContentType.ApplicationDividertf => "application/rtf",
                MediaContentType.ApplicationDividevndApacheParquet => "application/vnd.apache.parquet",
                MediaContentType.ApplicationDividevndMsExcel => "application/vnd.ms-excel",
                MediaContentType.ApplicationDividevndOpenxmlformatsOfficedocumentPresentationmlPresentation => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                MediaContentType.ApplicationDividevndOpenxmlformatsOfficedocumentSpreadsheetmlSheet => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                MediaContentType.ApplicationDividevndOpenxmlformatsOfficedocumentWordprocessingmlDocument => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                MediaContentType.ApplicationDividex7zCompressed => "application/x-7z-compressed",
                MediaContentType.ApplicationDividexNdjson => "application/x-ndjson",
                MediaContentType.ApplicationDividexTar => "application/x-tar",
                MediaContentType.ApplicationDividexYaml => "application/x-yaml",
                MediaContentType.ApplicationDividexml => "application/xml",
                MediaContentType.ApplicationDividezip => "application/zip",
                MediaContentType.AudioDivideaac => "audio/aac",
                MediaContentType.AudioDivideflac => "audio/flac",
                MediaContentType.AudioDividemp3 => "audio/mp3",
                MediaContentType.AudioDividemp4 => "audio/mp4",
                MediaContentType.AudioDividempeg => "audio/mpeg",
                MediaContentType.AudioDivideoga => "audio/oga",
                MediaContentType.AudioDivideogg => "audio/ogg",
                MediaContentType.AudioDivideopus => "audio/opus",
                MediaContentType.AudioDividewav => "audio/wav",
                MediaContentType.AudioDividewebm => "audio/webm",
                MediaContentType.ImageDivideavif => "image/avif",
                MediaContentType.ImageDividebmp => "image/bmp",
                MediaContentType.ImageDividegif => "image/gif",
                MediaContentType.ImageDivideheic => "image/heic",
                MediaContentType.ImageDividejpeg => "image/jpeg",
                MediaContentType.ImageDividejpg => "image/jpg",
                MediaContentType.ImageDividepng => "image/png",
                MediaContentType.ImageDividesvgPlusxml => "image/svg+xml",
                MediaContentType.ImageDividetiff => "image/tiff",
                MediaContentType.ImageDividewebp => "image/webp",
                MediaContentType.TextDividecss => "text/css",
                MediaContentType.TextDividecsv => "text/csv",
                MediaContentType.TextDividehtml => "text/html",
                MediaContentType.TextDividemarkdown => "text/markdown",
                MediaContentType.TextDivideplain => "text/plain",
                MediaContentType.TextDividexPython => "text/x-python",
                MediaContentType.TextDividexTypescript => "text/x-typescript",
                MediaContentType.VideoDividemp4 => "video/mp4",
                MediaContentType.VideoDividempeg => "video/mpeg",
                MediaContentType.VideoDivideogg => "video/ogg",
                MediaContentType.VideoDividequicktime => "video/quicktime",
                MediaContentType.VideoDividewebm => "video/webm",
                MediaContentType.VideoDividexMatroska => "video/x-matroska",
                MediaContentType.VideoDividexMsvideo => "video/x-msvideo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/gzip" => MediaContentType.ApplicationDividegzip,
                "application/javascript" => MediaContentType.ApplicationDividejavascript,
                "application/json" => MediaContentType.ApplicationDividejson,
                "application/msword" => MediaContentType.ApplicationDividemsword,
                "application/octet-stream" => MediaContentType.ApplicationDivideoctetStream,
                "application/pdf" => MediaContentType.ApplicationDividepdf,
                "application/rtf" => MediaContentType.ApplicationDividertf,
                "application/vnd.apache.parquet" => MediaContentType.ApplicationDividevndApacheParquet,
                "application/vnd.ms-excel" => MediaContentType.ApplicationDividevndMsExcel,
                "application/vnd.openxmlformats-officedocument.presentationml.presentation" => MediaContentType.ApplicationDividevndOpenxmlformatsOfficedocumentPresentationmlPresentation,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" => MediaContentType.ApplicationDividevndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document" => MediaContentType.ApplicationDividevndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
                "application/x-7z-compressed" => MediaContentType.ApplicationDividex7zCompressed,
                "application/x-ndjson" => MediaContentType.ApplicationDividexNdjson,
                "application/x-tar" => MediaContentType.ApplicationDividexTar,
                "application/x-yaml" => MediaContentType.ApplicationDividexYaml,
                "application/xml" => MediaContentType.ApplicationDividexml,
                "application/zip" => MediaContentType.ApplicationDividezip,
                "audio/aac" => MediaContentType.AudioDivideaac,
                "audio/flac" => MediaContentType.AudioDivideflac,
                "audio/mp3" => MediaContentType.AudioDividemp3,
                "audio/mp4" => MediaContentType.AudioDividemp4,
                "audio/mpeg" => MediaContentType.AudioDividempeg,
                "audio/oga" => MediaContentType.AudioDivideoga,
                "audio/ogg" => MediaContentType.AudioDivideogg,
                "audio/opus" => MediaContentType.AudioDivideopus,
                "audio/wav" => MediaContentType.AudioDividewav,
                "audio/webm" => MediaContentType.AudioDividewebm,
                "image/avif" => MediaContentType.ImageDivideavif,
                "image/bmp" => MediaContentType.ImageDividebmp,
                "image/gif" => MediaContentType.ImageDividegif,
                "image/heic" => MediaContentType.ImageDivideheic,
                "image/jpeg" => MediaContentType.ImageDividejpeg,
                "image/jpg" => MediaContentType.ImageDividejpg,
                "image/png" => MediaContentType.ImageDividepng,
                "image/svg+xml" => MediaContentType.ImageDividesvgPlusxml,
                "image/tiff" => MediaContentType.ImageDividetiff,
                "image/webp" => MediaContentType.ImageDividewebp,
                "text/css" => MediaContentType.TextDividecss,
                "text/csv" => MediaContentType.TextDividecsv,
                "text/html" => MediaContentType.TextDividehtml,
                "text/markdown" => MediaContentType.TextDividemarkdown,
                "text/plain" => MediaContentType.TextDivideplain,
                "text/x-python" => MediaContentType.TextDividexPython,
                "text/x-typescript" => MediaContentType.TextDividexTypescript,
                "video/mp4" => MediaContentType.VideoDividemp4,
                "video/mpeg" => MediaContentType.VideoDividempeg,
                "video/ogg" => MediaContentType.VideoDivideogg,
                "video/quicktime" => MediaContentType.VideoDividequicktime,
                "video/webm" => MediaContentType.VideoDividewebm,
                "video/x-matroska" => MediaContentType.VideoDividexMatroska,
                "video/x-msvideo" => MediaContentType.VideoDividexMsvideo,
                _ => null,
            };
        }
    }
}