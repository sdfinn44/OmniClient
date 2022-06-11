using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniClient.Models;

public class Job
{
    public string Id { get; set; }
    public string JobName { get; set; } 
    public string Description { get; set; }
    public string PipelineName { get; set; }
    public string RunAs { get; set; }
    public DateTime? ScheduleTime { get; set; }
    public string? StartStep { get; set; }
    public string? ClusterName { get; set; }
    public string? ServerName { get; set; }
    public string? InstanceName { get; set; }
    public List<Parameter> GlobalParameters { get; set; }
}
