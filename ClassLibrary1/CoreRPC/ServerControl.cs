
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.Control;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="ServerControl"/> class.
    /// Contains all methods for performing <seealso cref="ServerControl"/> operations.
    /// </summary>
    public class ServerControl
    {
        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;
        public ServerControl(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }

        /**<summary>Returns an object containing information about memory usage.</summary>
         <param name="mode">determines what kind of information is returned.
           - "stats" returns general statistics about memory usage in the daemon.
           - "mallocinfo" returns an XML string describing low-level heap state (only available if compiled with glibc 2.10+).</param>
         **/

        public async Task<string> GetMemoryInfo(Mode mode = Mode.Stats)
        {
            string response = await httpRequest.SendReq(MethodName.getmemoryinfo, mode);
            return response;
        }
        /**<summary>Returns details of the RPC server.</summary>**/
        public async Task<string> GetRpcInfo()
        {
            string response = await httpRequest.SendReq(MethodName.getrpcinfo);
            return response;
        }
        /**<summary>Get help for a specified command.</summary>**/
        ///<param name="command">The command to get help on.</param>
        public async Task<string> Help(CommandHelp command)
        {
            string response = await httpRequest.SendReq(MethodName.help, command);
            return response;
        }
        /**<summary>List all commands.</summary>**/
        public async Task<string> Help()
        {
            string response = await httpRequest.SendReq(MethodName.help);
            return response;
        }

        /**<summary>When called without an argument, returns the list of categories with status that are currently being debug logged or not.</summary>**/
        public async Task<string> Logging()
        {
            string response = await httpRequest.SendReq(MethodName.logging);
            return response;
        }

        /**<summary> Adds or removes categories from debug logging and returns the complete list.</summary>**/
        ///<param name="exclude">The categories to remove from debug logging.</param>
        ///<param name="include">The categories to add to debug logging.</param>
        public async Task<string> Logging(List<LoggingCategories> include = null, List<LoggingCategories> exclude = null)
        {
            Logging logging = new Logging { Include = include, Exclude = exclude };
            string response = await httpRequest.SendReq(MethodName.logging, logging);
            return response;
        }
        /**<summary>Stops Bitcoin server.</summary>**/
        public async Task<string> StopServer()
        {

            string response = await httpRequest.SendReq(MethodName.stop);
            return response;
        }
        /**<summary>Returns the total uptime of the server. The number of seconds that the server has been running.</summary>**/
        public async Task<string> Uptime()
        {

            string response = await httpRequest.SendReq(MethodName.uptime);
            return response;
        }

    }

}
