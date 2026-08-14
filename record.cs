using System.Data.Common;
using System.IO;
using System.Net.Cache;
using Microsoft.VisualBasic;

var req = new Request("aaa", 10);
var res = new Response("aaa", "meow meow");

var (id, dat) = req;
Console.WriteLine($"Request id {id} and num {dat}");

record Request(string id, int value);
record Response(string id, string data);