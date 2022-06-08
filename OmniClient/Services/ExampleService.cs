using OmniClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniClient.Services;

public class ExampleService
{
    public async Task<List<Example>> GetExamples()
    {
        var result =  new List<Example>();
        result.Add(new Example { Name = "Steve", Description = "King" });
        result.Add(new Example { Name = "Fred", Description = "Dibnah" });

        return result;
    }

}
