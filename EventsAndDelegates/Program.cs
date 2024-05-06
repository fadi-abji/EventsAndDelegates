// See https://aka.ms/new-console-template for more information
using EventsAndDelegates;

Console.WriteLine("start the app!");


var video = new Video() { Title = "Video 1" };
var videoEncoder  = new VideoEncoder();

videoEncoder.Encode(video);
