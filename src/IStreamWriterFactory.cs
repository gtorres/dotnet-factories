using Wizkisoft.DotNet.Wrapper;

namespace Wizkisoft.DotNet.Factory
{
    public interface IStreamWriterFactory
    {
        IStreamWriter GetStreamWriter(string filePath);
    }
}
