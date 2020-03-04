using Wizkisoft.DotNet.Wrapper;

namespace Wizkisoft.DotNet.Factory
{
    public class StreamWriterFactory : IStreamWriterFactory
    {
        public IStreamWriter GetStreamWriter(string filePath) => new StreamWriterWrapper(filePath);
    }
}
