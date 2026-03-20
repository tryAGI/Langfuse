
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
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageJpg,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
        /// <summary>
        /// 
        /// </summary>
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        ImageSvgPlusxml,
        /// <summary>
        /// 
        /// </summary>
        ImageTiff,
        /// <summary>
        /// 
        /// </summary>
        ImageBmp,
        /// <summary>
        /// 
        /// </summary>
        ImageAvif,
        /// <summary>
        /// 
        /// </summary>
        ImageHeic,
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        AudioMp3,
        /// <summary>
        /// 
        /// </summary>
        AudioWav,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg,
        /// <summary>
        /// 
        /// </summary>
        AudioOga,
        /// <summary>
        /// 
        /// </summary>
        AudioAac,
        /// <summary>
        /// 
        /// </summary>
        AudioMp4,
        /// <summary>
        /// 
        /// </summary>
        AudioFlac,
        /// <summary>
        /// 
        /// </summary>
        AudioOpus,
        /// <summary>
        /// 
        /// </summary>
        AudioWebm,
        /// <summary>
        /// 
        /// </summary>
        VideoMp4,
        /// <summary>
        /// 
        /// </summary>
        VideoWebm,
        /// <summary>
        /// 
        /// </summary>
        VideoOgg,
        /// <summary>
        /// 
        /// </summary>
        VideoMpeg,
        /// <summary>
        /// 
        /// </summary>
        VideoQuicktime,
        /// <summary>
        /// 
        /// </summary>
        VideoXMsvideo,
        /// <summary>
        /// 
        /// </summary>
        VideoXMatroska,
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
        /// <summary>
        /// 
        /// </summary>
        TextHtml,
        /// <summary>
        /// 
        /// </summary>
        TextCss,
        /// <summary>
        /// 
        /// </summary>
        TextCsv,
        /// <summary>
        /// 
        /// </summary>
        TextMarkdown,
        /// <summary>
        /// 
        /// </summary>
        TextXPython,
        /// <summary>
        /// 
        /// </summary>
        ApplicationJavascript,
        /// <summary>
        /// 
        /// </summary>
        TextXTypescript,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXYaml,
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationMsword,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndMsExcel,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
        /// <summary>
        /// 
        /// </summary>
        ApplicationZip,
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXml,
        /// <summary>
        /// 
        /// </summary>
        ApplicationOctetStream,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        /// <summary>
        /// 
        /// </summary>
        ApplicationRtf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXNdjson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndApacheParquet,
        /// <summary>
        /// 
        /// </summary>
        ApplicationGzip,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXTar,
        /// <summary>
        /// 
        /// </summary>
        ApplicationX7zCompressed,
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
                MediaContentType.ImagePng => "image/png",
                MediaContentType.ImageJpeg => "image/jpeg",
                MediaContentType.ImageJpg => "image/jpg",
                MediaContentType.ImageWebp => "image/webp",
                MediaContentType.ImageGif => "image/gif",
                MediaContentType.ImageSvgPlusxml => "image/svg+xml",
                MediaContentType.ImageTiff => "image/tiff",
                MediaContentType.ImageBmp => "image/bmp",
                MediaContentType.ImageAvif => "image/avif",
                MediaContentType.ImageHeic => "image/heic",
                MediaContentType.AudioMpeg => "audio/mpeg",
                MediaContentType.AudioMp3 => "audio/mp3",
                MediaContentType.AudioWav => "audio/wav",
                MediaContentType.AudioOgg => "audio/ogg",
                MediaContentType.AudioOga => "audio/oga",
                MediaContentType.AudioAac => "audio/aac",
                MediaContentType.AudioMp4 => "audio/mp4",
                MediaContentType.AudioFlac => "audio/flac",
                MediaContentType.AudioOpus => "audio/opus",
                MediaContentType.AudioWebm => "audio/webm",
                MediaContentType.VideoMp4 => "video/mp4",
                MediaContentType.VideoWebm => "video/webm",
                MediaContentType.VideoOgg => "video/ogg",
                MediaContentType.VideoMpeg => "video/mpeg",
                MediaContentType.VideoQuicktime => "video/quicktime",
                MediaContentType.VideoXMsvideo => "video/x-msvideo",
                MediaContentType.VideoXMatroska => "video/x-matroska",
                MediaContentType.TextPlain => "text/plain",
                MediaContentType.TextHtml => "text/html",
                MediaContentType.TextCss => "text/css",
                MediaContentType.TextCsv => "text/csv",
                MediaContentType.TextMarkdown => "text/markdown",
                MediaContentType.TextXPython => "text/x-python",
                MediaContentType.ApplicationJavascript => "application/javascript",
                MediaContentType.TextXTypescript => "text/x-typescript",
                MediaContentType.ApplicationXYaml => "application/x-yaml",
                MediaContentType.ApplicationPdf => "application/pdf",
                MediaContentType.ApplicationMsword => "application/msword",
                MediaContentType.ApplicationVndMsExcel => "application/vnd.ms-excel",
                MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                MediaContentType.ApplicationZip => "application/zip",
                MediaContentType.ApplicationJson => "application/json",
                MediaContentType.ApplicationXml => "application/xml",
                MediaContentType.ApplicationOctetStream => "application/octet-stream",
                MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                MediaContentType.ApplicationRtf => "application/rtf",
                MediaContentType.ApplicationXNdjson => "application/x-ndjson",
                MediaContentType.ApplicationVndApacheParquet => "application/vnd.apache.parquet",
                MediaContentType.ApplicationGzip => "application/gzip",
                MediaContentType.ApplicationXTar => "application/x-tar",
                MediaContentType.ApplicationX7zCompressed => "application/x-7z-compressed",
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
                "image/png" => MediaContentType.ImagePng,
                "image/jpeg" => MediaContentType.ImageJpeg,
                "image/jpg" => MediaContentType.ImageJpg,
                "image/webp" => MediaContentType.ImageWebp,
                "image/gif" => MediaContentType.ImageGif,
                "image/svg+xml" => MediaContentType.ImageSvgPlusxml,
                "image/tiff" => MediaContentType.ImageTiff,
                "image/bmp" => MediaContentType.ImageBmp,
                "image/avif" => MediaContentType.ImageAvif,
                "image/heic" => MediaContentType.ImageHeic,
                "audio/mpeg" => MediaContentType.AudioMpeg,
                "audio/mp3" => MediaContentType.AudioMp3,
                "audio/wav" => MediaContentType.AudioWav,
                "audio/ogg" => MediaContentType.AudioOgg,
                "audio/oga" => MediaContentType.AudioOga,
                "audio/aac" => MediaContentType.AudioAac,
                "audio/mp4" => MediaContentType.AudioMp4,
                "audio/flac" => MediaContentType.AudioFlac,
                "audio/opus" => MediaContentType.AudioOpus,
                "audio/webm" => MediaContentType.AudioWebm,
                "video/mp4" => MediaContentType.VideoMp4,
                "video/webm" => MediaContentType.VideoWebm,
                "video/ogg" => MediaContentType.VideoOgg,
                "video/mpeg" => MediaContentType.VideoMpeg,
                "video/quicktime" => MediaContentType.VideoQuicktime,
                "video/x-msvideo" => MediaContentType.VideoXMsvideo,
                "video/x-matroska" => MediaContentType.VideoXMatroska,
                "text/plain" => MediaContentType.TextPlain,
                "text/html" => MediaContentType.TextHtml,
                "text/css" => MediaContentType.TextCss,
                "text/csv" => MediaContentType.TextCsv,
                "text/markdown" => MediaContentType.TextMarkdown,
                "text/x-python" => MediaContentType.TextXPython,
                "application/javascript" => MediaContentType.ApplicationJavascript,
                "text/x-typescript" => MediaContentType.TextXTypescript,
                "application/x-yaml" => MediaContentType.ApplicationXYaml,
                "application/pdf" => MediaContentType.ApplicationPdf,
                "application/msword" => MediaContentType.ApplicationMsword,
                "application/vnd.ms-excel" => MediaContentType.ApplicationVndMsExcel,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" => MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
                "application/zip" => MediaContentType.ApplicationZip,
                "application/json" => MediaContentType.ApplicationJson,
                "application/xml" => MediaContentType.ApplicationXml,
                "application/octet-stream" => MediaContentType.ApplicationOctetStream,
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document" => MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
                "application/vnd.openxmlformats-officedocument.presentationml.presentation" => MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
                "application/rtf" => MediaContentType.ApplicationRtf,
                "application/x-ndjson" => MediaContentType.ApplicationXNdjson,
                "application/vnd.apache.parquet" => MediaContentType.ApplicationVndApacheParquet,
                "application/gzip" => MediaContentType.ApplicationGzip,
                "application/x-tar" => MediaContentType.ApplicationXTar,
                "application/x-7z-compressed" => MediaContentType.ApplicationX7zCompressed,
                _ => null,
            };
        }
    }
}