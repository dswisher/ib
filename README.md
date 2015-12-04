# Code Snippets related to Interactive Brokers' APIs #

This repo contains some sample code that uses the [Interactive Brokers](https://www.interactivebrokers.com/) APIs.

### Using the Samples ###

Interactive Brokers has two flavors of their API: a proprietary protocol and FIX CTC protocol. They provide a C# library for their proprietary protocol, so for the moment at least, that's what this code uses.

To run the samples, you will need to download and install a couple of things from the IB web site:

0. Create an account on the IB web site. You just need to supply name and e-mail address (the first step). There are additional steps to create an actual brokerage account, but you can skip those later steps (until you are ready to actually trade).
1. The [IB API](http://interactivebrokers.github.io/). Keep the default location (C:\TWS API), or you will need to change the path(s) in the C# project file(s).
2. The IB Gateway software. Go to the [IB home page](https://www.interactivebrokers.com/), click the login drop-down in the upper right, then click "IB Gateway Latest", and you will be taken to a page where you can download the software.

Note: When starting the IB gateway, make sure you choose "IB API" at the top of the login screen. In addition, you may get a prompt from windows firewall that you should probably accept.

Note: when building the project, if you get an error about updating the registry, the easiest thing to do is to run Visual Studio as an Administrator. The IB API registers itself for COM interop.

