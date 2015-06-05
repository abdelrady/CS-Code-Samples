using System;
using System.IO;
using System.IO.Compression;

public class GZipTest
{
    public static int ReadAllBytesFromStream(Stream stream, byte[] buffer)
    {
        // Use this method is used to read all bytes from a stream.
        int offset = 0;
        int totalCount = 0;
        while (true)
        {
            int bytesRead = stream.Read(buffer, offset, 100);
            if (bytesRead == 0)
            {
                break;
            }
            offset += bytesRead;
            totalCount += bytesRead;
        }
        return totalCount;
    }

    public static bool CompareData(byte[] buf1, int len1, byte[] buf2, int len2)
    {
        // Use this method to compare data from two different buffers.
        if (len1 != len2)
        {
            Console.WriteLine("Number of bytes in two buffer are different {0}:{1}", len1, len2);
            return false;
        }

        for (int i = 0; i < len1; i++)
        {
            if (buf1[i] != buf2[i])
            {
                Console.WriteLine("byte {0} is different {1}|{2}", i, buf1[i], buf2[i]);
                return false;
            }
        }
        Console.WriteLine("All bytes compare.");
        return true;
    }

    public static void GZipCompressDecompress(string filename)
    {
        Console.WriteLine("Test compression and decompression on file {0}", filename);
        FileStream infile;
        try
        {
            // Open the file as a FileStream object.
            infile = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] buffer = new byte[infile.Length];
            // Read the file to ensure it is readable.
            int count = infile.Read(buffer, 0, buffer.Length);
            if (count != buffer.Length)
            {
                infile.Close();
                Console.WriteLine("Test Failed: Unable to read data from file");
                return;
            }
            infile.Close();
            MemoryStream ms = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();
            // Use the newly created memory stream for the compressed data.
            GZipStream compressedzipStream = new GZipStream(ms, CompressionMode.Compress, true);
            Console.WriteLine("Compression");
            compressedzipStream.Write(buffer, 0, buffer.Length);
            // Close the stream.
            compressedzipStream.Close();
            Console.WriteLine("Original size: {0}, Compressed size: {1}", buffer.Length, ms.Length);

            compressedzipStream = new GZipStream(ms2, CompressionMode.Compress, true);
            byte[] compressedData = ms.ToArray();
            
            compressedzipStream.Write(compressedData, 0, compressedData.Length);
            Console.WriteLine("Original size: {0}, Compressed size: {1}", ms.Length, ms2.Length);
            // Close the stream.
            compressedzipStream.Close();

            //save int file
            File.WriteAllBytes(filename + "a", ms2.ToArray());
            //
            
            // Reset the memory stream position to begin decompression.
            ms.Position = 0;
            GZipStream zipStream = new GZipStream(ms, CompressionMode.Decompress);
            Console.WriteLine("Decompression");
            byte[] decompressedBuffer = new byte[buffer.Length + 100];
            // Use the ReadAllBytesFromStream to read the stream.
            int totalCount = GZipTest.ReadAllBytesFromStream(zipStream, decompressedBuffer);
            Console.WriteLine("Decompressed {0} bytes", totalCount);

            if (!GZipTest.CompareData(buffer, buffer.Length, decompressedBuffer, totalCount))
            {
                Console.WriteLine("Error. The two buffers did not compare.");
            }
            zipStream.Close();
        } // end try
        catch (InvalidDataException)
        {
            Console.WriteLine("Error: The file being read contains invalid data.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error:The file specified was not found.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error: path is a zero-length string, contains only white space, or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Error: The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Error: The specified path is invalid, such as being on an unmapped drive.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error: An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: path specified a file that is read-only, the path is a directory, or caller does not have the required permissions.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: You must provide parameters for MyGZIP.");
        }
    }
    public static void Main(string[] args)
    {
       /* string usageText = "Usage: MYGZIP <inputfilename>";
        //If no file name is specified, write usage text.
        if (args.Length == 0)
        {
            Console.WriteLine(usageText);
        }
        else
        {
            if (File.Exists(args[0]))
                GZipCompressDecompress(args[0]);
        }*/

        string filePath = "";
        Console.Write("Enter File Path To Compress & Decompress: ");
        if (File.Exists(filePath = Console.ReadLine()))
            GZipCompressDecompress(filePath);
    }
}
