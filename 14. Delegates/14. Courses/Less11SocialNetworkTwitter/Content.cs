using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11SocialNetworkTwitter
{
    /// <summary>
    /// Represents the base class for different types of content.
    /// </summary>
    public abstract class Content { }

    /// <summary>
    /// Represents audio content.
    /// </summary>
    class Audio : Content { }

    /// <summary>
    /// Represents document content.
    /// </summary>
    class Document : Content { }

    /// <summary>
    /// Represents image content.
    /// </summary>
    class Image : Content { }
}
