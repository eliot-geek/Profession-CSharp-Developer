using System;

namespace Less03DelegateAPIService
{
    /// <summary>
    /// Simulates an API service for retrieving data.
    /// </summary>
    internal class ApiService
    {
        /// <summary>
        /// Gets dummy data from the API service.
        /// </summary>
        /// <returns>A string containing the dummy data.</returns>
        public static string GetData()
        {
            string data = String.Empty;

            for (int i = 0; i < 10; i++)
            {
                data += Guid.NewGuid().ToString();
            }
            return data;
        }

        /* 
        Guid.NewGuid() generates a new globally unique identifier (GUID). A GUID is a 128-bit value typically represented as a 32-character hexadecimal string, 
        often separated by hyphens into five groups in the form 8-4-4-4-12 characters.
        ToString() is a method call that converts the generated GUID into its string representation. 

        Example of the Output:

        9de81fcf-e38f-41e5-825c-84bbff446bd7
        ce1315e3-21ad-45d5-8562-20f99ab05d3b
        a222c6bc-47b2-4937-9757-ba5d01b4a683
        d731d97f-156c-4b6f-8c9c-12c89a0f81b5
        c0ab23ab-8c49-4e24-af85-0ac9f3ed7db2
        5c49e3cb-2383-4d7b-8eac-b8cb1b7e8b25
        c3aa90c5-4a86-460e-96c0-72eb175f7e34
        72e6d4bc-0303-4a4f-8e34-028f4dcefbf7
        8d58ae16-0d50-403a-a6f4-8a5ebcfc0ef6
        6b30b88e-3a88-452a-9d67-3b19f0d1d0cb

        */
    }
}
