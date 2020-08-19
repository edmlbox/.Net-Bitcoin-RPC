
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.Blockchain;
using BitcoinRpc.RequestModels.Control;
using BitcoinRpc.RequestModels.Generate;
using BitcoinRpc.RequestModels.Mining;
using BitcoinRpc.RequestModels.Network;
using BitcoinRpc.RequestModels.RawTransactions;
using BitcoinRpc.RequestModels.Util;
using BitcoinRpc.RequestModels.Wallet;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BitcoinRpc
{
    class CaseWriter
    {
        public void GetBlockStats(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetBlockStats getBlockStats = (GetBlockStats)guesType;

            string blockHash = getBlockStats.BlockHash as string;
            int height = 0;

            if (blockHash != null) { writer.WriteStringValue(blockHash); }
            else
            {
                height = (int)getBlockStats.Height;
                writer.WriteNumberValue(height);
            };

            writer.WriteStartArray();
            if (getBlockStats.BlockStatsFilter != null)
            {
                foreach (BlockStatsFilter filter in getBlockStats.BlockStatsFilter)
                {
                    writer.WriteStringValue(filter.ToString());
                }
            }

            writer.WriteEndArray();
            writer.WriteEndArray();
        }
        public void GetBlockHeader(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetBlockHeader getBlockHeader = (GetBlockHeader)guesType;
            writer.WriteStringValue(getBlockHeader.Blockhash);

            writer.WriteBooleanValue(getBlockHeader.BlockHeaderVerbosityConverter());
            writer.WriteEndArray();
        }
        public void GetBlockFilter(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetBlockFilter getBlockFilter = (GetBlockFilter)guesType;

            //Argument 1 (required)
            writer.WriteStringValue(getBlockFilter.Blockhash);

            //Argument 2 (optional)
            if (getBlockFilter.FilterType != null)
            {
                writer.WriteStringValue(getBlockFilter.FilterType);
            }
            writer.WriteEndArray();

        }
        public void GetBlockHash(string methodName, object guesType, Utf8JsonWriter writer)
        {
            writer.WriteNumberValue((int)guesType);
            writer.WriteEndArray();
        }
        public void GetBlock(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetBlock getBlock = (GetBlock)guesType;
            writer.WriteStringValue(getBlock.Blockhash);
            writer.WriteNumberValue((Decimal)getBlock.Verbosity);
            writer.WriteEndArray();
        }
        public void GenerateToDescriptor(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GenerateToDescriptor generateToDescriptor = (GenerateToDescriptor)guesType;

            writer.WriteNumberValue(generateToDescriptor.NumBlocks);
            writer.WriteStringValue(generateToDescriptor.Descriptor);
            writer.WriteNumberValue(generateToDescriptor.Maxtries);
            writer.WriteEndArray();
        }
        public void GetChainTxStats(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetChainTxStats getChainTxStats = (GetChainTxStats)guesType;

            if (getChainTxStats.FinalBlockhash == "optional, default=chain tip")
            {
                writer.WriteNumberValue(getChainTxStats.NBlocks);
            }
            else if (getChainTxStats.FinalBlockhash == null)
            {
                writer.WriteNumberValue(getChainTxStats.NBlocks);

            }
            else if (!string.IsNullOrEmpty(getChainTxStats.FinalBlockhash) && getChainTxStats.FinalBlockhash != "optional, default = chain tip")
            {
                writer.WriteNumberValue(getChainTxStats.NBlocks);
                writer.WriteStringValue(getChainTxStats.FinalBlockhash);
            }

            writer.WriteEndArray();
        }
        public void GetMempoolAncestors(string methodName, object guesType, Utf8JsonWriter writer)
        {//GetMemPool used for "caseGetmempoolancestors and caseGetmempooldescendants" 
            //methods because parameters the same.
            //
            GetMemPool memPoolAncestors = (GetMemPool)guesType;
            writer.WriteStringValue(memPoolAncestors.Txid);
            writer.WriteBooleanValue(memPoolAncestors.BlockHeaderVerbosityConverter());
            writer.WriteEndArray();

        }
        public void GetMempoolDescendants(string methodName, object guesType, Utf8JsonWriter writer)
        {//GetMemPool used for "caseGetmempoolancestors and caseGetmempooldescendants" 
            //methods because parameters the same.
            //
            GetMemPool memPoolAncestors = (GetMemPool)guesType;
            writer.WriteStringValue(memPoolAncestors.Txid);
            writer.WriteBooleanValue(memPoolAncestors.BlockHeaderVerbosityConverter());
            writer.WriteEndArray();

        }
        public void GetMempoolEntry(string methodName, object guesType, Utf8JsonWriter writer)
        {//GetMemPool used for "caseGetmempoolancestors and caseGetmempooldescendants and caseGetmempoolentry" 
         //methods because parameters the same.

            GetMemPool memPoolAncestors = (GetMemPool)guesType;
            writer.WriteStringValue(memPoolAncestors.Txid);
            writer.WriteEndArray();

        }
        public void GetRawMempool(string methodName, object guesType, Utf8JsonWriter writer)
        {//GetMemPool used for "caseGetmempoolancestors and caseGetmempooldescendants and caseGetmempoolentry and caseGetrawmempool" 
         //methods because parameters the same.

            GetMemPool memPoolAncestors = (GetMemPool)guesType;
            writer.WriteBooleanValue(memPoolAncestors.BlockHeaderVerbosityConverter());
            writer.WriteEndArray();

        }
        public void GetTxOut(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetTxOut getTxOut = (GetTxOut)guesType;
            writer.WriteStringValue(getTxOut.Txid);
            writer.WriteNumberValue(getTxOut.VoutNumber);
            writer.WriteBooleanValue(getTxOut.IncludeTheMemPool);
            writer.WriteEndArray();
        }
        public void GetTxOutProof(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetTxOutProof txOutProof = (GetTxOutProof)guesType;
            writer.WriteStartArray();
            foreach (string txids in txOutProof.ArrayOfTxids)
            {
                writer.WriteStringValue(txids);
            }
            writer.WriteEndArray();
            if (txOutProof.Blockhash != null) { writer.WriteStringValue(txOutProof.Blockhash); }
            writer.WriteEndArray();

        }
        public void PreciousBlock(string methodName, object guesType, Utf8JsonWriter writer)
        {

            writer.WriteStringValue(guesType as string);
            writer.WriteEndArray();
        }

        public void PruneBlockchain(string methodName, object guesType, Utf8JsonWriter writer)
        {
            PruneBlockChain pruneBlockChain = (PruneBlockChain)guesType;
            if (pruneBlockChain.Height != 0) { writer.WriteNumberValue(pruneBlockChain.Height); }
            else { writer.WriteNumberValue(pruneBlockChain.UnixTimestamp); }

            writer.WriteEndArray();
        }

        //EXPERIMENTAL warning: this call may be removed or changed in future releases.
        public void ScanTxOutSet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ScanTxOutSet scanTxOutSet = (ScanTxOutSet)guesType;
            string action = scanTxOutSet.ToString();
            writer.WriteStringValue(action);
            writer.WriteStartArray();

            foreach (string i in scanTxOutSet.ScanObjects)
            {
                string fullString = $"{scanTxOutSet.Descriptor.ToString()}({i})";
                writer.WriteStringValue(fullString);
            }




            writer.WriteEndArray();
            writer.WriteEndArray();
        }
        public void VerifyChain(string methodName, object guesType, Utf8JsonWriter writer)
        {
            Verifychain verifychain = (Verifychain)guesType;
            writer.WriteNumberValue(verifychain.CheckLevel);
            writer.WriteNumberValue(verifychain.NBlocks);
            writer.WriteEndArray();
        }
        public void VerifyTxOutProof(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string HexProof = (string)guesType;

            writer.WriteStringValue(HexProof);
            writer.WriteEndArray();


        }
        public void GetMemoryInfo(string methodName, object guesType, Utf8JsonWriter writer)
        {
            Mode getMemoryInfo = (Mode)guesType;

            string mode = getMemoryInfo.ToString().ToLower();
            writer.WriteStringValue(mode);
            writer.WriteEndArray();

        }
        public void Help(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string command = ((CommandHelp)guesType).ToString();
            writer.WriteStringValue(command);
            writer.WriteEndArray();
        }
        public void Logging(string methodName, object guesType, Utf8JsonWriter writer)
        {
            Logging logging = (Logging)guesType;

            if (logging.Include != null && logging.Include.Count > 0)
            {
                writer.WriteStartArray();
                foreach (LoggingCategories loggingCategories in logging.Include)
                {
                    writer.WriteStringValue(loggingCategories.ToString());
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteStartArray();
                writer.WriteEndArray();
            }

            if (logging.Exclude != null && logging.Exclude.Count > 0)
            {

                writer.WriteStartArray();
                foreach (LoggingCategories loggingCategories in logging.Exclude)
                {
                    writer.WriteStringValue(loggingCategories.ToString());
                }
                writer.WriteEndArray();
            }

            writer.WriteEndArray();


        }

        public void Generate(string methodName, object guesType, Utf8JsonWriter writer)
        {
            Generate generate = (Generate)guesType;
            writer.WriteNumberValue(generate.NBlocks);
            writer.WriteNumberValue(generate.Maxtries);
            writer.WriteEndArray();
        }

        public void GenerateToAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            Generate generate = (Generate)guesType;
            writer.WriteNumberValue(generate.NBlocks);
            writer.WriteStringValue(generate.Address);
            writer.WriteNumberValue(generate.Maxtries);
            writer.WriteEndArray();
        }
        public void GetBlockTemplate(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetBlockTemplate getBlockTemplate = (GetBlockTemplate)guesType;

            writer.WriteStartObject();


            if (getBlockTemplate.Mode == TemplateRequest.template)
            {
                writer.WriteString(JsonKey.mode, getBlockTemplate.Mode.ToString());
            }
            else if (getBlockTemplate.Mode == TemplateRequest.proposal)
            {
                writer.WriteString(JsonKey.mode, getBlockTemplate.Mode.ToString());

            }
            //LONG POOL SECTION BEGIN
            if (getBlockTemplate.LongPollId != null)
            {
                //longpollid
                if (!string.IsNullOrEmpty(getBlockTemplate.LongPollId))
                {
                    writer.WriteString(JsonKey.longpollid, getBlockTemplate.LongPollId);
                }


            }

            //LONG POOL SECTION END

            //TEMPLATE TWEAKING BEGIN
            if (getBlockTemplate.TemplateTweaking != null)
            {
                TemplateTweaking templateTweaking = getBlockTemplate.TemplateTweaking;

                SizeLimit sizeLimit = templateTweaking.SizeLimit;
                SigopLimit sigopLimit = templateTweaking.SigopLimit;

                if (sizeLimit != null)
                {
                    if (sizeLimit.SizeLimitBoolean != null) { writer.WriteBoolean(JsonKey.sizelimit, (bool)sizeLimit.SizeLimitBoolean); }
                    else if (sizeLimit.SizeLimitNumber != null) { writer.WriteNumber(JsonKey.sizelimit, (int)sizeLimit.SizeLimitNumber); }
                }
                if (sigopLimit != null)
                {
                    if (sigopLimit.SigopLimitBoolean != null) { writer.WriteBoolean(JsonKey.sigoplimit, (bool)sigopLimit.SigopLimitBoolean); }
                    else if (sigopLimit.SigopLimitNumber != null) { writer.WriteNumber(JsonKey.sigoplimit, (int)sigopLimit.SigopLimitNumber); }
                }
                if (templateTweaking.MaxVersion != null) { writer.WriteNumber(JsonKey.maxversion, (int)templateTweaking.MaxVersion); }

            }
            //TEMPLATE TWEAKING END

            //RULES
            if (getBlockTemplate.Rules != Rules.none)
            {
                writer.WritePropertyName(JsonKey.rules);
                writer.WriteStartArray();
                writer.WriteStringValue(getBlockTemplate.Rules.ToString());
                writer.WriteEndArray();

            }

            //Bip23
            if (getBlockTemplate.Target != null)
            {
                writer.WriteString(JsonKey.target, getBlockTemplate.Target);
            }


            if (getBlockTemplate.Data != null)
            {
                writer.WriteString(JsonKey.data, getBlockTemplate.Data);
            }

            if (getBlockTemplate.WorkId != null)
            {
                writer.WriteString(JsonKey.workid, getBlockTemplate.WorkId);
            }

            if (getBlockTemplate.Nonces != null)
            {
                writer.WriteNumber(JsonKey.nonces, (int)getBlockTemplate.Nonces);
            }

            //Server List
            if (getBlockTemplate.ServerList != null && getBlockTemplate.ServerList.Count > 0)
            {
                writer.WritePropertyName(JsonKey.serverlist);
                writer.WriteStartArray();
                foreach (Server serverList in getBlockTemplate.ServerList)
                {

                    writer.WriteStartObject();

                    writer.WritePropertyName(JsonKey.uri);
                    writer.WriteStringValue(serverList.Uri);



                    writer.WritePropertyName(JsonKey.priority);
                    writer.WriteNumberValue(serverList.Priority);

                    if (serverList.Sticky != null)
                    {
                        writer.WritePropertyName(JsonKey.sticky);
                        writer.WriteNumberValue((int)serverList.Sticky);
                    }

                    if (serverList.Avoid != null)
                    {
                        writer.WritePropertyName(JsonKey.avoid);
                        writer.WriteNumberValue((int)serverList.Avoid);

                    }


                    writer.WritePropertyName(JsonKey.update);
                    writer.WriteBooleanValue(serverList.Update);

                    writer.WritePropertyName(JsonKey.weight);
                    writer.WriteNumberValue(serverList.Weight);


                    writer.WriteEndObject();



                }
                writer.WriteEndArray();

            }




            //Check for Capabilities and add them
            int capabilities_count = getBlockTemplate.Capabilities.Count;

            if (capabilities_count > 0)
            {

                writer.WritePropertyName(JsonKey.capabilities);
                writer.WriteStartArray();

                foreach (Capabilities capability in getBlockTemplate.Capabilities)
                {
                    string _capability = capability.ToString();
                    writer.WriteStringValue(_capability);
                }

                //Check for mutations and add them

                if (getBlockTemplate.Mutations != null && getBlockTemplate.Mutations.Count > 0)
                {
                    foreach (Mutable mutable in getBlockTemplate.Mutations)
                    {
                        string mutationName = EnumConverter.ConvertMutable(mutable);
                        writer.WriteStringValue(mutationName);
                    }

                }

                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndArray();

        }
        public void GetNetworkHashPS(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetNetworkHashPS getNetworkHashPS = (GetNetworkHashPS)guesType;
            writer.WriteNumberValue(getNetworkHashPS.NBlocks);
            writer.WriteNumberValue(getNetworkHashPS.Height);
            writer.WriteEndArray();

        }
        public void PrioritiseTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            PrioritiseTransaction prioritiseTransaction = (PrioritiseTransaction)guesType;
            writer.WriteStringValue(prioritiseTransaction.Txid);
            writer.WriteNumberValue(prioritiseTransaction.Dummy);
            writer.WriteNumberValue(prioritiseTransaction.FeeDelta);
            writer.WriteEndArray();

        }
        public void SubmitBlock(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SubmitBlock submitBlock = (SubmitBlock)guesType;
            writer.WriteStringValue(submitBlock.HexData);

            if (!string.IsNullOrEmpty(submitBlock.Dummy))
            {
                writer.WriteStringValue(submitBlock.Dummy);
            }
            writer.WriteEndArray();
        }

        public void SubmitHeader(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string hexdata = (string)guesType;
            writer.WriteStringValue(hexdata);
            writer.WriteEndArray();

        }
        public void AddNode(string methodName, object guesType, Utf8JsonWriter writer)
        {
            AddNode addNode = (AddNode)guesType;

            writer.WriteStringValue(addNode.Node);

            writer.WriteStringValue(addNode.NodeCommand.ToString());
            writer.WriteEndArray();
        }
        public void DisconnectNode(string methodName, object guesType, Utf8JsonWriter writer)
        {
            DisconnectNode disconnectNode = (DisconnectNode)guesType;
            if (disconnectNode.NodeAddress == null)
            {
                writer.WriteStringValue("");
            }
            else if (disconnectNode.NodeAddress != null)
            {
                writer.WriteStringValue(disconnectNode.NodeAddress);
            }

            if (disconnectNode.NodeId != null)
            {
                writer.WriteNumberValue((int)disconnectNode.NodeId);
            }
            writer.WriteEndArray();


        }

        public void GetAddedNodeInfo(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string node = (string)guesType;
            writer.WriteStringValue(node);
            writer.WriteEndArray();
        }

        public void GetNodeAddresses(string methodName, object guesType, Utf8JsonWriter writer)
        {
            int count = (int)guesType;
            writer.WriteNumberValue(count);
            writer.WriteEndArray();

        }


        public void SetBan(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SetBan setBan = (SetBan)guesType;
            writer.WriteStringValue(setBan.Subnet);
            writer.WriteStringValue(setBan.BanCommand.ToString());
            writer.WriteNumberValue(setBan.BanTime);
            writer.WriteBooleanValue(setBan.Absolute);
            writer.WriteEndArray();

        }


        public void State(string methodName, object guesType, Utf8JsonWriter writer)
        {
            bool state = (bool)guesType;
            writer.WriteBooleanValue(state);
            writer.WriteEndArray();

        }
        public void AnalyzePSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string PSBT = (string)guesType;
            writer.WriteStringValue(PSBT);
            writer.WriteEndArray();

        }

        public void CombinePSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {

            string[] PSBT = guesType as string[];
            List<string> PSBT_List = guesType as List<string>;

            if (PSBT != null && PSBT.Length > 0)
            {
                writer.WriteStartArray();
                foreach (string txid in PSBT)
                {
                    writer.WriteStringValue(txid);
                }
                writer.WriteEndArray();
            }
            else if (PSBT_List != null && PSBT_List.Count > 0)
            {
                writer.WriteStartArray();
                foreach (string txid in PSBT_List)
                {
                    writer.WriteStringValue(txid);
                }
                writer.WriteEndArray();
            }




            writer.WriteEndArray();

        }
        public void CombineRawTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {

            string[] PSBT = guesType as string[];
            List<string> PSBT_List = guesType as List<string>;

            if (PSBT != null && PSBT.Length > 0)
            {
                writer.WriteStartArray();
                foreach (string txid in PSBT)
                {
                    writer.WriteStringValue(txid);
                }
                writer.WriteEndArray();
            }
            else if (PSBT_List != null && PSBT_List.Count > 0)
            {
                writer.WriteStartArray();
                foreach (string txid in PSBT_List)
                {
                    writer.WriteStringValue(txid);
                }
                writer.WriteEndArray();
            }




            writer.WriteEndArray();

        }
        public void ConvertToPSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ConvertToPSBT convertToPSBT = (ConvertToPSBT)guesType;
            writer.WriteStringValue(convertToPSBT.HexString);
            writer.WriteBooleanValue(convertToPSBT.PermitSigData);
            writer.WriteBooleanValue(convertToPSBT.IsWitness);
            writer.WriteEndArray();

        }

        public void CreatePSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            CreatePSBT createPSBT = (CreatePSBT)guesType;
            List<PSBTInput> inputs = createPSBT.PSBT_Inputs;
            List<PSBTOutput> outputs = createPSBT.PSBT_Outputs;

            //Argument 1. (json array, required) The json objects.

            writer.WriteStartArray();
            foreach (PSBTInput input in inputs)
            {
                writer.WriteStartObject();
                //(string, required) The transaction id
                writer.WriteString(JsonKey.txid, input.Txid);
                //(numeric, required) The output number
                writer.WriteNumber(JsonKey.vout, input.Vout);
                //(numeric, optional) The sequence number.
                if (input.Sequence != null)
                {
                    writer.WriteNumber(JsonKey.sequence, (int)input.Sequence);
                }
                writer.WriteEndObject();

            }
            writer.WriteEndArray();

            //Argument 2. (json array, required) The outputs (key-value pairs), where none of the keys are duplicated.
            writer.WriteStartArray();

            foreach (PSBTOutput output in outputs)
            {

                object amount = output.Amount;
                string typeName = amount.GetType().Name.ToLower();

                writer.WriteStartObject();
                // Writes Address and amount
                if (typeName == "string") { writer.WriteString(output.Address, (string)amount); }
                else if (typeName == "single") { writer.WriteNumber(output.Address, (float)amount); }

                writer.WriteEndObject();
            }
            writer.WriteStartObject();
            //Writes key=data  value=hexString
            writer.WriteString(JsonKey.data, createPSBT.Data);
            writer.WriteEndObject();

            writer.WriteEndArray();

            //Argument 3. Locktime.
            if (createPSBT.Locktime != null) { writer.WriteNumberValue((int)createPSBT.Locktime); }

            //Argument 4. Replaceable.
            if (createPSBT.Replaceable != null) { writer.WriteBooleanValue((bool)createPSBT.Replaceable); }

            writer.WriteEndArray();


        }
        public void CreateRawTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            CreateRawTransaction createRawTransaction = (CreateRawTransaction)guesType;

            RawInputs rawInputs = createRawTransaction.RawInputs;
            RawOutputs rawOutputs = createRawTransaction.RawOutputs;

            int lockTime = createRawTransaction.Locktime;
            bool replaceable = createRawTransaction.Replaceable;

            //inputs writer
            if (rawInputs != null)
            {
                if (rawInputs.Inputs.Count > 0)
                {
                    writer.WriteStartArray();
                    foreach (RawInput input in rawInputs.Inputs)
                    {
                        writer.WriteStartObject();
                        writer.WriteString(JsonKey.txid, input.Txid);
                        writer.WriteNumber(JsonKey.vout, input.Vout);
                        if (input.Sequence != null) { writer.WriteNumber(JsonKey.sequence, (int)input.Sequence); }
                        writer.WriteEndObject();
                    }
                    writer.WriteEndArray();
                }
            }
            else { writer.WriteStartArray(); writer.WriteEndArray(); }


            //outputs writer
            if (rawOutputs != null)
            {
                if (rawOutputs.Outputs.Count > 0)
                {
                    writer.WriteStartArray();
                    foreach (RawOutput output in rawOutputs.Outputs)
                    {
                        writer.WriteStartObject();
                        if (!string.IsNullOrEmpty(output.Amount))
                        {
                            writer.WriteString(output.Address, output.Amount);
                        }
                        else { writer.WriteNumber(output.Address, (float)output.AmountInFloat); }

                        writer.WriteEndObject();
                    }

                    if (rawOutputs.HexEncodedData != null)
                    {
                        writer.WriteStartObject();
                        writer.WriteString(JsonKey.data, rawOutputs.HexEncodedData);
                        writer.WriteEndObject();
                    }
                    writer.WriteEndArray();
                }
            }
            else
            {
                writer.WriteStartArray(); writer.WriteEndArray();
            }


            writer.WriteNumberValue(lockTime);
            writer.WriteBooleanValue(replaceable);

            writer.WriteEndArray();

        }
        public void DecodePSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string PSBT = (string)guesType;
            writer.WriteStringValue(PSBT);
            writer.WriteEndArray();



        }
        public void DecodeRawTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            DecodeRawTransaction decodeRawTransaction = (DecodeRawTransaction)guesType;
            writer.WriteStringValue(decodeRawTransaction.HexString);
            if (decodeRawTransaction.IsWitness != null)
            {
                writer.WriteBooleanValue((bool)decodeRawTransaction.IsWitness);
            }

            writer.WriteEndArray();

        }
        public void DecodeScript(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string hexString = (string)guesType;
            writer.WriteStringValue(hexString);
            writer.WriteEndArray();

        }
        public void FinalizePSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            FinalizePSBT finalizePSBT = (FinalizePSBT)guesType;

            writer.WriteStringValue(finalizePSBT.PSBT);

            if (finalizePSBT.Extract != null) { writer.WriteBooleanValue((bool)finalizePSBT.Extract); }

            writer.WriteEndArray();

        }
        public void FundRawTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            FundRawTransaction fundRawTransaction = (FundRawTransaction)guesType;
            FundOptions fundOptions = fundRawTransaction.FundOptions;

            if (!String.IsNullOrEmpty(fundRawTransaction.HexString))
            {
                writer.WriteStringValue(fundRawTransaction.HexString);
            }

            if (fundOptions != null)
            {

                writer.WriteStartObject();
                object feeRate = fundOptions.GetFreeRate();
                Type type;
                //feeRate single or string
                if (feeRate != null)
                {
                    type = feeRate.GetType();

                    if (type.Name.ToLower() == "single")
                    {

                        float _feeRate = (float)feeRate;
                        writer.WriteNumber(JsonKey.feeRate, _feeRate);
                    }
                    else if (type.Name.ToLower() == "string")
                    {
                        string _feeRate = (string)feeRate as string;

                        if (!string.IsNullOrWhiteSpace(_feeRate))
                        {
                            writer.WriteString(JsonKey.feeRate, _feeRate);
                        }
                    }

                }

                //ChangeAddress
                if (fundOptions.ChangeAddress != null)
                {
                    writer.WriteString(JsonKey.changeAddress, fundOptions.ChangeAddress);
                }
                //ChangePosition
                if (fundOptions.ChangePosition != null)
                {
                    writer.WriteNumber(JsonKey.changePosition, (int)fundOptions.ChangePosition);
                }
                //Change_Type
                if (fundOptions.ChangeType != null)
                {
                    writer.WriteString(JsonKey.change_type, EnumConverter.ConvertChangeType((ChangeType)fundOptions.ChangeType));
                }
                //Conf_Target
                if (fundOptions.ConfTarget != null)
                {
                    writer.WriteNumber(JsonKey.conf_target, (int)fundOptions.ConfTarget);
                }
                //LockUnspents
                if (fundOptions.LockUnspents != null)
                {
                    writer.WriteBoolean(JsonKey.lockUnspents, (bool)fundOptions.LockUnspents);
                }
                //Replaceable
                if (fundOptions.Replaceable != null)
                {
                    writer.WriteBoolean(JsonKey.replaceable, (bool)fundOptions.Replaceable);
                }
                //IncludeWatching
                if (fundOptions.IncludeWatching != null)
                {
                    writer.WriteBoolean(JsonKey.includeWatching, (bool)fundOptions.IncludeWatching);
                }
                //EstimateMode
                if (fundOptions.EstimateMode != null)
                {
                    writer.WriteString(JsonKey.estimate_mode, fundOptions.EstimateMode.ToString());
                }
                //Subtract_Fee_From_Outputs
                if (fundOptions.SubtractFeeFromOutputs != null && fundOptions.SubtractFeeFromOutputs.Length > 0)
                {
                    writer.WritePropertyName(JsonKey.subtractFeeFromOutputs);
                    writer.WriteStartArray();
                    foreach (int vout_index in fundOptions.SubtractFeeFromOutputs)
                    {
                        writer.WriteNumberValue(vout_index);
                    }
                    writer.WriteEndArray();
                }

                writer.WriteEndObject();
                if (fundRawTransaction.IsWitness != null)
                {
                    writer.WriteBooleanValue((bool)fundRawTransaction.IsWitness);
                }

            }
            writer.WriteEndArray();
        }

        public void GetRawTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetRawTransaction getRawTransaction = (GetRawTransaction)guesType;

            writer.WriteStringValue(getRawTransaction.Txid);
            if (getRawTransaction.ReturnType != null)
            {
                bool verbose = getRawTransaction.ConvertToBool((TXReturnType)getRawTransaction.ReturnType);
                writer.WriteBooleanValue(verbose);
            }
            if (getRawTransaction.Blockhash != null)
            {
                writer.WriteStringValue(getRawTransaction.Blockhash);
            }

            writer.WriteEndArray();

        }
        public void JoinPSBTS(string methodName, object guesType, Utf8JsonWriter writer)
        {

            string[] txs = guesType as string[];
            List<string> txsList = guesType as List<string>;

            writer.WriteStartArray();
            if (txs != null)
            {
                foreach (string tx in txs)
                {
                    writer.WriteStringValue(tx);
                }
            }
            else
            {
                foreach (string tx in txsList)
                {
                    writer.WriteStringValue(tx);
                }
            }

            writer.WriteEndArray();
            writer.WriteEndArray();
        }

        public void SendRawTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SendRawTransaction rawTransaction = (SendRawTransaction)guesType;

            writer.WriteStringValue(rawTransaction.HexString);

            if (rawTransaction.MaxFeeRate != null)
            {
                writer.WriteNumberValue((float)rawTransaction.MaxFeeRate);
            }

            if (rawTransaction.AllowHighFees != null)
            {
                writer.WriteBooleanValue((bool)rawTransaction.AllowHighFees);
            }

            writer.WriteEndArray();
        }

        public void SignRawTransactionWithKey(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SignRawTransactionWithKey signRawTransactionWithKey = (SignRawTransactionWithKey)guesType;
            List<PrevTxs> prevTxs = signRawTransactionWithKey.PrevTxs;

            //hexString, required.
            writer.WriteStringValue(signRawTransactionWithKey.Hexstring);

            //A json array of base58-encoded private keys for signing,  required.
            writer.WriteStartArray();
            foreach (string privKey in signRawTransactionWithKey.PrivKeys)
            {
                writer.WriteStringValue(privKey);
            }
            writer.WriteEndArray();

            //A json array of previous dependent transaction outputs, optional.
            if (prevTxs != null)
            {
                writer.WriteStartArray();
                foreach (PrevTxs prevTx in prevTxs)
                {
                    writer.WriteStartObject();

                    //(string, required) The transaction id
                    writer.WriteString(JsonKey.txid, prevTx.Txid);

                    //(numeric, required) The output number
                    writer.WriteNumber(JsonKey.vout, prevTx.Vout);

                    //(string, required) script key
                    writer.WriteString(JsonKey.scriptPubKey, prevTx.ScriptPubKey);

                    //(string) (required for P2SH) redeem script
                    if (!string.IsNullOrEmpty(prevTx.RedeemScript))
                    {
                        writer.WriteString(JsonKey.redeemScript, prevTx.RedeemScript);
                    }

                    //(string) (required for P2WSH or P2SH-P2WSH) witness script
                    if (!string.IsNullOrEmpty(prevTx.WitnessScript))
                    {
                        writer.WriteString(JsonKey.witnessScript, prevTx.WitnessScript);
                    }

                    //(numeric or string, required) The amount spent
                    object amount = prevTx.Amount;
                    string amountTypeName = amount.GetType().Name;

                    //if amount is float
                    if (amountTypeName.ToLower() == "single")
                    {

                        writer.WriteNumber(JsonKey.amount, (float)amount);
                    }
                    //if amount is string
                    else if (amountTypeName.ToLower() == "string")
                    {
                        writer.WriteString(JsonKey.amount, (string)amount);
                    }


                    writer.WriteEndObject();
                }

                writer.WriteEndArray();

                // The signature hash type. string, optional, default=ALL
                if (signRawTransactionWithKey.HashType != null)
                {
                    string sigHashType = EnumConverter.GetSigHashType((SigHashType)signRawTransactionWithKey.HashType);
                    writer.WriteStringValue(sigHashType);
                }
            }



            writer.WriteEndArray();
        }

        public void TestMemPoolAccept(string methodName, object guesType, Utf8JsonWriter writer)
        {
            TestMemPoolAccept testMemPoolAccept = (TestMemPoolAccept)guesType;

            //(required) An array of hex strings of raw transactions. Length must be one for now. 
            writer.WriteStartArray();
            if (testMemPoolAccept.RawTxs != null && testMemPoolAccept.RawTxs.Count > 0)
            {
                foreach (string tx in testMemPoolAccept.RawTxs)
                {
                    writer.WriteStringValue(tx);
                }

            }
            else if (!string.IsNullOrEmpty(testMemPoolAccept.RawTx))
            {
                writer.WriteStringValue(testMemPoolAccept.RawTx);
            }

            writer.WriteEndArray();
            //MaxFeeRate

            if (testMemPoolAccept.MaxFeeRate != null)
            {
                string typeName = testMemPoolAccept.MaxFeeRate.GetType().Name.ToLower();
                //write string or float to request parameters.
                if (typeName == "single") { writer.WriteNumberValue((float)testMemPoolAccept.MaxFeeRate); }
                else if (typeName == "string") { writer.WriteStringValue((string)testMemPoolAccept.MaxFeeRate); }

            }

            writer.WriteEndArray();
        }
        public void UtxoUpdatePSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            UtxoUpdatePSBT utxoUpdatePSBT = (UtxoUpdatePSBT)guesType;
            List<string> stringDescriptors = utxoUpdatePSBT.OutputDescriptors;
            List<OutputDescriptor> outputDescriptors = utxoUpdatePSBT.OutputDescriptorsWithExtra;

            //Argument 1(string, required) A base64 string of a PSBT.
            writer.WriteStringValue(utxoUpdatePSBT.PSBT);

            //Argument 2(json array, optional) An array of either strings or objects.
            if (stringDescriptors != null)
            {
                writer.WriteStartArray();
                foreach (string OutputDescriptor in stringDescriptors)
                {
                    writer.WriteStringValue(OutputDescriptor);
                }
                writer.WriteEndArray();
            }
            else if (outputDescriptors != null)
            {
                writer.WriteStartArray();
                foreach (OutputDescriptor outputDescriptor in outputDescriptors)
                {
                    writer.WriteStartObject();
                    writer.WriteString(JsonKey.desc, outputDescriptor.Desc);
                    object range = outputDescriptor.Range;

                    if (range != null)
                    {
                        string typeName = range.GetType().Name.ToLower();
                        if (typeName == "int32")
                        {
                            writer.WriteNumber(JsonKey.range, (int)range);
                        }
                        else if (typeName == "int32[]")
                        {

                            Int32[] beginEnd = (Int32[])range;
                            writer.WritePropertyName(JsonKey.range);
                            writer.WriteStartArray();
                            foreach (int index in beginEnd)
                            {
                                writer.WriteNumberValue(index);
                            }
                            writer.WriteEndArray();
                        }
                    }

                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }
            writer.WriteEndArray();


        }
        //
        public void CreateMultisig(string methodName, object guesType, Utf8JsonWriter writer)
        {
            CreateMultisig createMultisig = (CreateMultisig)guesType;

            //Argument 1
            writer.WriteNumberValue(createMultisig.NRequired);

            //Argument 2
            writer.WriteStartArray();
            foreach (string pubKey in createMultisig.PublicKeys)
            {
                writer.WriteStringValue(pubKey);
            }
            writer.WriteEndArray();

            //Argument 3
            if (createMultisig.AddressType != null)
            {
                string convertedAddress = EnumConverter.ConvertChangeType((AddressType)createMultisig.AddressType);
                writer.WriteStringValue(convertedAddress);
            }


            writer.WriteEndArray();

        }
        public void DeriveAddresses(string methodName, object guesType, Utf8JsonWriter writer)
        {

            DeriveAddresses deriveAddresses = (DeriveAddresses)guesType;

            writer.WriteStringValue(deriveAddresses.Descriptor);

            if (deriveAddresses.BeginRange != null)
            {
                writer.WriteStartArray();
                writer.WriteNumberValue((int)deriveAddresses.BeginRange);
                writer.WriteNumberValue((int)deriveAddresses.EndRange);
                writer.WriteEndArray();
            }
            else if (deriveAddresses.EndRange != null)
            {
                writer.WriteNumberValue((int)deriveAddresses.EndRange);
            }
            writer.WriteEndArray();



        }
        public void EstimateSmartFee(string methodName, object guesType, Utf8JsonWriter writer)
        {
            EstimateSmartFee estimateSmartFee = (EstimateSmartFee)guesType;
            writer.WriteNumberValue(estimateSmartFee.ConfTarget);
            if (estimateSmartFee.EstimateMode != null)
            {
                writer.WriteStringValue(estimateSmartFee.EstimateMode.ToString());
            }
            writer.WriteEndArray();
        }
        public void GetDescriptorInfo(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string descriptor = (string)guesType;
            writer.WriteStringValue(descriptor);
            writer.WriteEndArray();


        }
        public void SignMessageWithPrivKey(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SignMessageWithPrivKey signMessageWithPriv = (SignMessageWithPrivKey)guesType;
            writer.WriteStringValue(signMessageWithPriv.Privkey);
            writer.WriteStringValue(signMessageWithPriv.Message);
            writer.WriteEndArray();

        }
        public void ValidateAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string address = (string)guesType;
            writer.WriteStringValue(address);
            writer.WriteEndArray();


        }
        public void VerifyMessage(string methodName, object guesType, Utf8JsonWriter writer)
        {
            VerifyMessage verifyMessage = (VerifyMessage)guesType;
            writer.WriteStringValue(verifyMessage.Address);
            writer.WriteStringValue(verifyMessage.Signature);
            writer.WriteStringValue(verifyMessage.Message);
            writer.WriteEndArray();


        }

        public void AbandonTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string txid = (string)guesType;
            writer.WriteStringValue(txid);
            writer.WriteEndArray();

        }
        public void AddMultisigAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            AddMultisigAddress addMultisigAddress = (AddMultisigAddress)guesType;

            //Argument 1
            writer.WriteNumberValue(addMultisigAddress.NRequired);

            //Argument 2
            writer.WriteStartArray();
            foreach (string key in addMultisigAddress.Keys)
            {
                writer.WriteStringValue(key);
            }
            writer.WriteEndArray();

            //Argument 3
            if (addMultisigAddress.Label != null)
            {
                writer.WriteStringValue(addMultisigAddress.Label);
            }

            //Argument 4
            if (addMultisigAddress.AddressType != null)
            {
                if (addMultisigAddress.Label == null) { writer.WriteNullValue(); }

                writer.WriteStringValue(EnumConverter.ConvertChangeType((AddressType)addMultisigAddress.AddressType));
            }

            writer.WriteEndArray();

        }
        public void BackupWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string path = (string)guesType;
            writer.WriteStringValue(path);
            writer.WriteEndArray();
        }

        //caseBumpFee
        public void BumpFee(string methodName, object guesType, Utf8JsonWriter writer)
        {
            BumpFee bumpFee = (BumpFee)guesType;
            BumpFeeOptions bumpFeeOptions = bumpFee.BumpFeeOptions;
            //Argument 1 (required)
            writer.WriteStringValue(bumpFee.Txid);

            //Argument 2 (optional)
            if (bumpFeeOptions != null)
            {
                writer.WriteStartObject();
                //Argument 2.1 (optional)
                if (bumpFeeOptions.ConfTarget != null) { writer.WriteNumber(JsonKey.confTarget, (int)bumpFeeOptions.ConfTarget); }
                //Argument 2.2 (optional)
                if (bumpFeeOptions.FeeRate != null) { writer.WriteNumber(JsonKey.fee_rate, (float)bumpFeeOptions.FeeRate); }
                //Argument 2.3 (optional)
                if (bumpFeeOptions.Replaceable != null) { writer.WriteBoolean(JsonKey.replaceable, (bool)bumpFeeOptions.Replaceable); }
                //Argument 2.4 (optional)
                if (bumpFeeOptions.EstimateMode != null) { writer.WriteString(JsonKey.estimate_mode, bumpFeeOptions.EstimateMode.ToString()); }
                writer.WriteEndObject();
            }


            writer.WriteEndArray();
        }
        public void CreateWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string typeName = guesType.GetType().Name.ToLower();
            if (typeName == "string") { writer.WriteStringValue((string)guesType); }
            else if (typeName == typeof(CreateWallet).Name.ToLower())
            {

                CreateWallet createWallet = (CreateWallet)guesType;
                //Argument 1 (required)
                writer.WriteStringValue(createWallet.WalletName);

                //Argument 2 (optional)
                if (createWallet.DisablePrivateKeys != null) { writer.WriteBooleanValue((bool)createWallet.DisablePrivateKeys); }
                else { writer.WriteNullValue(); }

                //Argument 3 (optional)
                if (createWallet.Blank != null) { writer.WriteBooleanValue((bool)createWallet.Blank); }
                else { writer.WriteNullValue(); }

                //Argument 4 (optional)
                if (createWallet.Passphrase != null) { writer.WriteStringValue(createWallet.Passphrase); }
                else { writer.WriteNullValue(); }

                //Argument 5 (optional)
                if (createWallet.AvoidReuse != null) { writer.WriteBooleanValue((bool)createWallet.AvoidReuse); }
                else { writer.WriteNullValue(); }
            }








            writer.WriteEndArray();

        }
        public void DumpPrivKey(string methodName, object guesType, Utf8JsonWriter writer)
        {
            writer.WriteStringValue((string)guesType);
            writer.WriteEndArray();
        }
        public void DumpWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            writer.WriteStringValue((string)guesType);
            writer.WriteEndArray();
        }

        //
        public void EncryptWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            writer.WriteStringValue((string)guesType);
            writer.WriteEndArray();
        }


        public void GetAddressesByLabel(string methodName, object guesType, Utf8JsonWriter writer)
        {
            writer.WriteStringValue((string)guesType);
            writer.WriteEndArray();
        }

        public void LoadWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            writer.WriteStringValue((string)guesType);
            writer.WriteEndArray();
        }

        public void GetAddressInfo(string methodName, object guesType, Utf8JsonWriter writer)
        {
            writer.WriteStringValue((string)guesType);
            writer.WriteEndArray();
        }
        public void GetBalance(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetBalance getBalance = (GetBalance)guesType;

            writer.WriteStringValue(getBalance.Dummy);
            writer.WriteNumberValue((int)getBalance.MinConf);
            writer.WriteBooleanValue((bool)getBalance.IncludeWatchOnly);
            writer.WriteBooleanValue((bool)getBalance.AvoidReuse);
            writer.WriteEndArray();
        }

        public void GetNewAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetNewAddress getNewAddress = (GetNewAddress)guesType;

            writer.WriteStringValue(getNewAddress.Label);
            writer.WriteStringValue(EnumConverter.ConvertChangeType((AddressType)getNewAddress.AddressType));
            writer.WriteEndArray();
        }
        public void GetRawChangeAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            //Argument 1 (optional)
            AddressType addressType = (AddressType)guesType;
            writer.WriteStringValue(EnumConverter.ConvertChangeType(addressType));
            writer.WriteEndArray();
        }
        public void GetReceivedByAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetReceivedByAddress getReceivedByAddress = (GetReceivedByAddress)guesType;
            //Argument 1 (required)
            writer.WriteStringValue(getReceivedByAddress.Address);
            //Argument 2 (optional)
            if (getReceivedByAddress.MinConf != null) { writer.WriteNumberValue((int)getReceivedByAddress.MinConf); }


            writer.WriteEndArray();
        }
        public void GetReceivedByLabel(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetReceivedByLabel getReceivedByLabel = (GetReceivedByLabel)guesType;

            //Argument 1 (required)
            writer.WriteStringValue(getReceivedByLabel.Label);

            //Argument 2 (optional)
            if (getReceivedByLabel.MinConf != null)
            {
                writer.WriteNumberValue((int)getReceivedByLabel.MinConf);
            }
            writer.WriteEndArray();
        }
        public void GetTransaction(string methodName, object guesType, Utf8JsonWriter writer)
        {
            GetTransaction getTransaction = (GetTransaction)guesType;

            writer.WriteStringValue(getTransaction.Txid);

            if (getTransaction.IncludeWatchOnly != null) { writer.WriteBooleanValue((bool)getTransaction.IncludeWatchOnly); }
            if (getTransaction.IncludeDecoded != null) { writer.WriteBooleanValue((bool)getTransaction.IncludeDecoded); }

            writer.WriteEndArray();
        }
        public void ImportAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ImportAddress importAddress = (ImportAddress)guesType;

            //Argument 1 (required)
            writer.WriteStringValue(importAddress.Address);

            //Argument 2 (optional)
            if (importAddress.Label != null) { writer.WriteStringValue(importAddress.Label); }

            //Argument 3 (optional)
            if (importAddress.Rescan != null) { writer.WriteBooleanValue((bool)importAddress.Rescan); }

            //Argument 4 (optional)
            if (importAddress.P2SH != null) { writer.WriteBooleanValue((bool)importAddress.P2SH); }

            writer.WriteEndArray();
        }
        public void ImportMulti(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ImportMulti importMulti = (ImportMulti)guesType;
            List<MultiData> multiDatas = importMulti.MultiData;

            writer.WriteStartArray();
            foreach (MultiData multiData in multiDatas)
            {
                ScriptPubKeyType? scriptPubKeyType = multiData.GetScriptPubKeyType();

                object timeStamp = multiData.Timestamp;
                string timeStampTypeName = null;

                if (timeStamp != null) { timeStampTypeName = timeStamp.GetType().Name.ToLower(); }

                List<string> pubkeys = multiData.Pubkeys;
                List<string> keys = multiData.Keys;

                object range = multiData.Range;
                string rangeTypeName = null;
                if (range != null) { rangeTypeName = range.GetType().Name.ToLower(); }


                writer.WriteStartObject();

                //Argument 1.1 "desc"
                if (multiData.Desc != null) { writer.WriteString(JsonKey.desc, multiData.Desc); }


                //Argument 1.2 "scriptPubKey"
                if (scriptPubKeyType == ScriptPubKeyType.Address)
                {

                    writer.WritePropertyName(JsonKey.scriptPubKey);
                    writer.WriteStartObject();

                    writer.WriteString(JsonKey.address, multiData.ScriptPubKey);
                    writer.WriteEndObject();

                }
                else if (scriptPubKeyType == ScriptPubKeyType.Script)
                {
                    writer.WriteString(JsonKey.scriptPubKey, multiData.ScriptPubKey);
                }


                //Argument 1.3  (required) "timestamp"
                if (timeStampTypeName != null && timeStampTypeName == "int64")
                {
                    writer.WriteNumber(JsonKey.timestamp, (long)multiData.Timestamp);
                }
                else if (timeStampTypeName != null && timeStampTypeName == "creationtime")
                {
                    writer.WriteString(JsonKey.timestamp, multiData.Timestamp.ToString().ToLower());
                }


                //Argument 1.4  (optional) "redeemscript"
                if (multiData.RedeemScript != null) { writer.WriteString(JsonKey.redeemscript, multiData.RedeemScript); }


                //Argument 1.5  (optional) "witnessscript"
                if (multiData.WitnessScript != null) { writer.WriteString(JsonKey.witnessscript, multiData.WitnessScript); }



                //Argument 1.6  (optional) "pubkeys"
                writer.WritePropertyName(JsonKey.pubkeys);
                if (pubkeys.Count > 0)
                {
                    writer.WriteStartArray();
                    foreach (string pubkey in pubkeys)
                    {
                        writer.WriteStringValue(pubkey);
                    }
                    writer.WriteEndArray();

                }
                else { writer.WriteStartArray(); writer.WriteEndArray(); }

                //Argument 1.7 (optional) "keys"
                writer.WritePropertyName(JsonKey.keys);
                if (keys.Count > 0)
                {
                    writer.WriteStartArray();
                    foreach (string key in keys)
                    {
                        writer.WriteStringValue(key);
                    }
                    writer.WriteEndArray();
                }
                else { writer.WriteStartArray(); writer.WriteEndArray(); }

                //Argument 1.8 (optional) "range"
                if (rangeTypeName != null && rangeTypeName == "int32")
                {

                    writer.WriteNumber(JsonKey.range, (int)range);
                }
                else if (rangeTypeName != null && rangeTypeName == "int32[]")
                {

                    Int32[] beginEnd = (Int32[])range;
                    writer.WritePropertyName(JsonKey.range);
                    writer.WriteStartArray();
                    writer.WriteNumberValue(beginEnd[0]);
                    writer.WriteNumberValue(beginEnd[1]);
                    writer.WriteEndArray();
                }
                //Argument 1.9 (optional) "internal"
                if (multiData.Internal != null) { writer.WriteBoolean(JsonKey._internal, (bool)multiData.Internal); }


                //Argument 1.10 (optional) "watchonly"
                if (multiData.WatchOnly != null) { writer.WriteBoolean(JsonKey.watchonly, (bool)multiData.WatchOnly); }


                //Argument 1.11 (optional) "label"

                if (multiData.Label != null) { writer.WriteString(JsonKey.label, multiData.Label); }

                //Argument 1.12 (optional) "keypool"
                if (multiData.Keypool != null) { writer.WriteBoolean(JsonKey.keypool, (bool)multiData.Keypool); }


                writer.WriteEndObject();

            }


            writer.WriteEndArray();

            //Argument 2 (optional) "rescan"
            if (importMulti.Rescan != null)
            {
                writer.WriteStartObject();
                writer.WriteBoolean(JsonKey.rescan, (bool)importMulti.Rescan);
                writer.WriteEndObject();

            }

            writer.WriteEndArray();


        }
        public void ImportPrivKey(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ImportPrivKey importPrivKey = (ImportPrivKey)guesType;

            //Argument 1 (required)
            writer.WriteStringValue(importPrivKey.PrivKey);

            //Argument 2 (optional)
            if (importPrivKey.Label != null)
            {
                writer.WriteStringValue(importPrivKey.Label);

            }
            else { writer.WriteNullValue(); }

            //Argument 3 (optional)
            if (importPrivKey.Rescan != null)
            {
                writer.WriteBooleanValue((bool)importPrivKey.Rescan);
            }

            writer.WriteEndArray();
        }

        public void ImportPrunedFunds(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ImportPrunedFunds importPrunedFunds = (ImportPrunedFunds)guesType;

            //Argument 1 (required)
            writer.WriteStringValue(importPrunedFunds.RawTransaction);
            //Argument 2 (required)
            writer.WriteStringValue(importPrunedFunds.TxOutProof);
            writer.WriteEndArray();
        }
        public void ImportPubkey(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ImportPubkey importPubkey = (ImportPubkey)guesType;

            //Argument 1 (required) "pubkey"
            writer.WriteStringValue(importPubkey.PubKey);

            //Argument 2 (optional) "label"
            if (importPubkey.Label != null) { writer.WriteStringValue(importPubkey.Label); }
            else
            {
                if (importPubkey.Rescan != null) { writer.WriteNullValue(); }
            }

            //Argument 3 (optional) "rescan"
            if (importPubkey.Rescan != null) { writer.WriteBooleanValue((bool)importPubkey.Rescan); }


            writer.WriteEndArray();
        }
        public void ImportWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string fileName = (string)guesType;
            writer.WriteStringValue(fileName);
            writer.WriteEndArray();

        }
        public void KeypoolRefill(string methodName, object guesType, Utf8JsonWriter writer)
        {

            //Argument 1 (optional)
            writer.WriteNumberValue((int)guesType);
            writer.WriteEndArray();
        }
        public void ListLabels(string methodName, object guesType, Utf8JsonWriter writer)
        {
            //Argument 1 (optional)
            string purpose = ((Purpose)guesType).ToString().ToLower();
            writer.WriteStringValue(purpose);
            writer.WriteEndArray();
        }
        public void ListReceivedByAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ListReceivedByAddress listReceivedByAddress = (ListReceivedByAddress)guesType;

            //Argument 1 (optional)
            writer.WriteNumberValue(listReceivedByAddress.MinConf);

            //Argument 2 (optional)
            writer.WriteBooleanValue(listReceivedByAddress.IncludeEmpty);

            //Argument 3 (optional)
            writer.WriteBooleanValue(listReceivedByAddress.IncludeWatchOnly);

            //Argument 4 (optional)
            if (listReceivedByAddress.AddressFilter != null) { writer.WriteStringValue(listReceivedByAddress.AddressFilter); }



            writer.WriteEndArray();
        }
        public void ListReceivedByLabel(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ListReceivedByLabel listReceivedByLabel = (ListReceivedByLabel)guesType;

            //Argument 1 (optional)
            writer.WriteNumberValue(listReceivedByLabel.MinConf);

            //Argument 2 (optional)
            writer.WriteBooleanValue(listReceivedByLabel.IncludeEmpty);

            //Argument 3 (optional)
            writer.WriteBooleanValue(listReceivedByLabel.IncludeWatchOnly);

            writer.WriteEndArray();


        }
        public void ListSinceBlock(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ListSinceBlock listSinceBlock = (ListSinceBlock)guesType;

            //Argument 1 (optional)
            writer.WriteStringValue(listSinceBlock.Blockhash);

            //Argument 2 (optional)
            writer.WriteNumberValue(listSinceBlock.TargetConfirmations);

            //Argument 3 (optional)
            writer.WriteBooleanValue(listSinceBlock.IncludeWatchOnly);

            //Argument 4 (optional)
            writer.WriteBooleanValue(listSinceBlock.IncludeRemoved);

            writer.WriteEndArray();

        }
        public void ListTransactions(string methodName, object guesType, Utf8JsonWriter writer)
        {

            ListTransactions listTransactions = (ListTransactions)guesType;

            writer.WriteStringValue(listTransactions.Label);
            writer.WriteNumberValue(listTransactions.Count);
            writer.WriteNumberValue(listTransactions.Skip);
            writer.WriteBooleanValue(listTransactions.IncludeWatchonly);

            writer.WriteEndArray();

        }
        public void ListUnspent(string methodName, object guesType, Utf8JsonWriter writer)
        {
            ListUnspent listUnspent = (ListUnspent)guesType;
            List<string> addresses = listUnspent.Addresses;
            QueryOptions queryOptions = listUnspent.QueryOptions;


            //Argument 1
            writer.WriteNumberValue(listUnspent.MinConf);

            //Argument 2
            writer.WriteNumberValue(listUnspent.MaxConf);

            //Argument 3
            if (addresses != null)
            {
                writer.WriteStartArray();
                foreach (string address in addresses)
                {
                    writer.WriteStringValue(address);
                }
                writer.WriteEndArray();
            }
            else { writer.WriteStartArray(); writer.WriteEndArray(); }

            //Argument 4
            writer.WriteBooleanValue(listUnspent.IncludeUnsafe);

            //Argument 5
            if (queryOptions != null)
            {
                writer.WriteStartObject();

                //Argument 5.1
                if (queryOptions.MinimumAmount != null)
                {
                    string typeName = queryOptions.MinimumAmount.GetType().Name.ToLower();
                    if (typeName == "single") { writer.WriteNumber(JsonKey.minimumAmount, (float)queryOptions.MinimumAmount); }
                    else if (typeName == "string") { writer.WriteString(JsonKey.minimumAmount, (string)queryOptions.MinimumAmount); }
                }

                //Argument 5.2
                if (queryOptions.MaximumAmount != null)
                {
                    string typeName = queryOptions.MaximumAmount.GetType().Name.ToLower();
                    if (typeName == "single") { writer.WriteNumber(JsonKey.maximumAmount, (float)queryOptions.MaximumAmount); }
                    else if (typeName == "string") { writer.WriteString(JsonKey.maximumAmount, (string)queryOptions.MaximumAmount); }
                }

                //Argument 5.3
                if (queryOptions.MaximumCount != null)
                {
                    writer.WriteNumber(JsonKey.maximumCount, (float)queryOptions.MaximumCount);
                }

                //Argument 5.4
                if (queryOptions.MinimumSumAmount != null)
                {
                    string typeName = queryOptions.MinimumSumAmount.GetType().Name.ToLower();
                    if (typeName == "single") { writer.WriteNumber(JsonKey.minimumSumAmount, (float)queryOptions.MinimumSumAmount); }
                    else if (typeName == "string") { writer.WriteString(JsonKey.minimumSumAmount, (string)queryOptions.MinimumSumAmount); }
                }

                writer.WriteEndObject();
            }





            writer.WriteEndArray();
        }
        public void LockUnspent(string methodName, object guesType, Utf8JsonWriter writer)
        {

            LockUnspent lockUnspent = (LockUnspent)guesType;
            List<TransactionOutputs> transactionOutputs = lockUnspent.TransactionOutputs;
            writer.WriteBooleanValue(lockUnspent.Unlock);

            if (transactionOutputs != null)
            {
                writer.WriteStartArray();
                foreach (TransactionOutputs txOut in transactionOutputs)
                {
                    writer.WriteStartObject();
                    writer.WriteString(JsonKey.txid, txOut.Txid);
                    writer.WriteNumber(JsonKey.vout, txOut.Vout);
                    writer.WriteEndObject();
                }

                writer.WriteEndArray();
            }

            writer.WriteEndArray();



        }

        public void RemovePrunedFunds(string methodName, object guesType, Utf8JsonWriter writer)
        {
            string txid = (string)guesType;
            writer.WriteStringValue(txid);
            writer.WriteEndArray();
        }
        public void RescanBlockchain(string methodName, object guesType, Utf8JsonWriter writer)
        {
            RescanBlockchain rescanBlockchain = (RescanBlockchain)guesType;
            writer.WriteNumberValue(rescanBlockchain.StartHeight);
            writer.WriteNumberValue(rescanBlockchain.StopHeight);
            writer.WriteEndArray();
        }
        public void SendMany(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SendMany sendMany = (SendMany)guesType;
            List<AddressAmount> addressAmounts = sendMany.AddressesAmounts;
            List<string> subtractFeeFrom = sendMany.SubtractFeeFrom;

            //Argument 1 (required). Must be set to "" for backwards compatibility.
            writer.WriteStringValue(sendMany.Dummy);

            //Argument 2 (required)
            writer.WriteStartObject();
            foreach (AddressAmount addressAmount in addressAmounts)
            {
                string typeName = addressAmount.Amount.GetType().Name.ToLower();
                if (typeName == "string") { writer.WriteString(addressAmount.Address, (string)addressAmount.Amount); }
                else if (typeName == "single") { writer.WriteNumber(addressAmount.Address, (float)addressAmount.Amount); }
            }
            writer.WriteEndObject();

            //Prevent remaining arguments to be written if they are null.
            if (sendMany.MinConf == null && sendMany.Replaceable == null && sendMany.EstimateMode == null && sendMany.ConfTarget == null && sendMany.Comment == null && sendMany.SubtractFeeFrom == null)
            {
                writer.WriteEndArray();
                return;
            }


            //Argument 3 (optional). Ignored dummy value
            if (sendMany.MinConf != null) { writer.WriteNumberValue((int)sendMany.MinConf); }
            else { writer.WriteNullValue(); }


            //Argument 4 (optional)
            if (sendMany.Comment != null) { writer.WriteStringValue(sendMany.Comment); }
            else { writer.WriteNullValue(); }

            // //Argument 5 (optional)
            if (subtractFeeFrom != null)
            {
                writer.WriteStartArray();
                foreach (string address in subtractFeeFrom)
                {
                    writer.WriteStringValue(address);
                }
                writer.WriteEndArray();
            }
            else { writer.WriteStartArray(); writer.WriteEndArray(); }

            //Argument 6 (optional)
            if (sendMany.Replaceable != null) { writer.WriteBooleanValue((bool)sendMany.Replaceable); }
            else { writer.WriteNullValue(); }


            //Argument 7 (optional)
            if (sendMany.ConfTarget != null) { writer.WriteNumberValue((int)sendMany.ConfTarget); }
            else { writer.WriteNullValue(); }

            //Argument 8 (optional)
            if (sendMany.EstimateMode != null) { writer.WriteStringValue(sendMany.EstimateMode.ToString()); }



            writer.WriteEndArray();
        }
        public void SendToAddress(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SendToAddress sendToAddress = (SendToAddress)guesType;
            string typeName = sendToAddress.Amount.GetType().Name.ToLower();

            //Argument 1 (required)
            writer.WriteStringValue(sendToAddress.Address);

            //Argument 2 (required)

            if (typeName == "string") { writer.WriteStringValue((string)sendToAddress.Amount); }
            else if (typeName == "single") { writer.WriteNumberValue((float)sendToAddress.Amount); }

            //Prevent remaining arguments to be written if they are null.
            if (sendToAddress.AvoidReuse == null && sendToAddress.Comment == null && sendToAddress.CommentTo == null && sendToAddress.ConfTarget == null && sendToAddress.Replaceable == null && sendToAddress.EstimateMode == null && sendToAddress.SubtractFeeFromAmount == null)
            {
                writer.WriteEndArray();
                return;
            }

            //Argument 3 (optional)
            if (sendToAddress.Comment != null) { writer.WriteStringValue(sendToAddress.Comment); }
            else { writer.WriteNullValue(); }

            //Argument 4 (optional)
            if (sendToAddress.CommentTo != null) { writer.WriteStringValue(sendToAddress.CommentTo); }
            else { writer.WriteNullValue(); }

            //Argument 5 (optional)
            if (sendToAddress.SubtractFeeFromAmount != null) { writer.WriteBooleanValue((bool)sendToAddress.SubtractFeeFromAmount); }
            else { writer.WriteNullValue(); }

            //Argument 6 (optional)
            if (sendToAddress.Replaceable != null) { writer.WriteBooleanValue((bool)sendToAddress.Replaceable); }
            else { writer.WriteNullValue(); }

            //Argument 7 (optional)
            if (sendToAddress.ConfTarget != null) { writer.WriteNumberValue((int)sendToAddress.ConfTarget); }
            else { writer.WriteNullValue(); }

            //Argument 8 (optional)
            if (sendToAddress.EstimateMode != null) { writer.WriteStringValue(sendToAddress.EstimateMode.ToString()); }
            else { writer.WriteNullValue(); }

            //Argument 9 (optional)
            if (sendToAddress.AvoidReuse != null) { writer.WriteBooleanValue((bool)sendToAddress.AvoidReuse); }





            writer.WriteEndArray();


        }
        public void SetHDSeed(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SetHDSeed setHDSeed = (SetHDSeed)guesType;

            writer.WriteBooleanValue(setHDSeed.NewKeypool);

            if (setHDSeed.Seed != null) { writer.WriteStringValue(setHDSeed.Seed); }


            writer.WriteEndArray();
        }
        public void SetLabel(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SetLabel setLabel = (SetLabel)guesType;

            writer.WriteStringValue(setLabel.Address);
            writer.WriteStringValue(setLabel.Label);
            writer.WriteEndArray();


        }
        public void SetTxFee(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SetTxFee setTxFee = (SetTxFee)guesType;
            string typeName = setTxFee.Amount.GetType().Name.ToLower();

            if (typeName == "string") { writer.WriteStringValue((string)setTxFee.Amount); }
            else if (typeName == "single") { writer.WriteNumberValue((float)setTxFee.Amount); }

            writer.WriteEndArray();


        }
        public void SetWalletFlag(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SetWalletFlag setWalletFlag = (SetWalletFlag)guesType;


            writer.WriteStringValue(setWalletFlag.Flag.ToString().ToLower());
            writer.WriteBooleanValue(setWalletFlag.Value);
            writer.WriteEndArray();

        }
        public void SignMessage(string methodName, object guesType, Utf8JsonWriter writer)
        {

            SignMessage signMessage = (SignMessage)guesType;

            writer.WriteStringValue(signMessage.Address);
            writer.WriteStringValue(signMessage.Message);
            writer.WriteEndArray();

        }
        public void SignRawTransactionWithWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            SignRawTransactionWithWallet signRawTransactionWithWallet = (SignRawTransactionWithWallet)guesType;
            List<PrevTxs> prevTxs = signRawTransactionWithWallet.PrevTxs;

            //Argument 1 (required)
            writer.WriteStringValue(signRawTransactionWithWallet.HexString);

            //Argument 2 (optional)
            if (prevTxs != null)
            {
                writer.WriteStartArray();
                foreach (PrevTxs item in prevTxs)
                {
                    writer.WriteStartObject();

                    //Argument 2.1

                    writer.WriteString(JsonKey.txid, item.Txid);
                    //Argument 2.2
                    writer.WriteNumber(JsonKey.vout, item.Vout);

                    //Argument 2.3
                    writer.WriteString(JsonKey.scriptPubKey, item.ScriptPubKey);

                    //Argument 2.4
                    writer.WriteString(JsonKey.redeemScript, item.RedeemScript);

                    //Argument 2.5
                    writer.WriteString(JsonKey.witnessScript, item.WitnessScript);

                    //Argument 2.6
                    if (item.Amount.GetType().Name.ToLower() == "string") { writer.WriteString(JsonKey.amount, (string)item.Amount); }
                    else if (item.Amount.GetType().Name.ToLower() == "single") { writer.WriteNumber(JsonKey.amount, (float)item.Amount); }
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }

            //Argument 3 (optional)
            if (signRawTransactionWithWallet.SigHashType != null)
            {
                writer.WriteStringValue(EnumConverter.GetSigHashType((SigHashType)signRawTransactionWithWallet.SigHashType));
            }

            writer.WriteEndArray();




        }
        public void UnloadWallet(string methodName, object guesType, Utf8JsonWriter writer)
        {
            //Argument 1 (optional)
            writer.WriteStringValue((string)guesType);
            writer.WriteEndArray();
        }
        public void WalletCreateFundedPSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            WalletCreateFundedPSBT walletCreateFundedPSBT = (WalletCreateFundedPSBT)guesType;
            List<RawInput> rawInputs = walletCreateFundedPSBT.Inputs;
            List<RawOutput> rawOutputs = walletCreateFundedPSBT.OutPuts;
            FundOptions fundOptions = walletCreateFundedPSBT.FundOptions;

            //Argument 1 (required)
            writer.WriteStartArray();
            foreach (RawInput input in rawInputs)
            {
                writer.WriteStartObject();

                //Argument 1.1 (required)
                writer.WriteString(JsonKey.txid, input.Txid);

                //Argument 1.2 (required)
                writer.WriteNumber(JsonKey.vout, input.Vout);

                //Argument 1.3 (required)
                if (input.Sequence != null) { writer.WriteNumber(JsonKey.sequence, (int)input.Sequence); }
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            //Argument 2 (required)
            writer.WriteStartArray();
            foreach (RawOutput output in rawOutputs)
            {
                //Argument 2.1 (required)
                writer.WriteStartObject();
                if (!string.IsNullOrEmpty(output.Amount))
                {
                    writer.WriteString(output.Address, output.Amount);
                }
                else { writer.WriteNumber(output.Address, (float)output.AmountInFloat); }
                writer.WriteEndObject();
            }

            //Argument 2.2 (required)
            if (walletCreateFundedPSBT.HexData != null)
            {
                writer.WriteStartObject();
                writer.WriteString(JsonKey.data, walletCreateFundedPSBT.HexData);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            //Argument 3 (optional)
            writer.WriteNumberValue((int)walletCreateFundedPSBT.LockTime);

            //Argument 4 (optional)
            if (fundOptions != null)
            {
                writer.WriteStartObject();
                object feeRate = fundOptions.GetFreeRate();
                Type type;

                //Argument 4.1 (optional)
                if (fundOptions.ChangeAddress != null)
                {
                    writer.WriteString(JsonKey.changeAddress, fundOptions.ChangeAddress);
                }

                //Argument 4.2 (optional)
                if (fundOptions.ChangePosition != null)
                {
                    writer.WriteNumber(JsonKey.changePosition, (int)fundOptions.ChangePosition);
                }

                //Argument 4.3 (optional)
                if (fundOptions.ChangeType != null)
                {
                    writer.WriteString(JsonKey.change_type, EnumConverter.ConvertChangeType((ChangeType)fundOptions.ChangeType));
                }

                //Argument 4.4 (optional)
                if (fundOptions.IncludeWatching != null)
                {
                    writer.WriteBoolean(JsonKey.includeWatching, (bool)fundOptions.IncludeWatching);
                }

                //Argument 4.5 (optional)
                if (fundOptions.LockUnspents != null)
                {
                    writer.WriteBoolean(JsonKey.lockUnspents, (bool)fundOptions.LockUnspents);
                }

                //Argument 4.6 (optional)
                if (feeRate != null)
                {
                    type = feeRate.GetType();
                    if (type.Name.ToLower() == "single")
                    {
                        float _feeRate = (float)feeRate;
                        writer.WriteNumber(JsonKey.feeRate, _feeRate);
                    }
                    else if (type.Name.ToLower() == "string")
                    {
                        string _feeRate = (string)feeRate as string;
                        if (!string.IsNullOrWhiteSpace(_feeRate))
                        {
                            writer.WriteString(JsonKey.feeRate, _feeRate);
                        }
                    }
                }

                //Argument 4.7 (optional)
                if (fundOptions.SubtractFeeFromOutputs != null && fundOptions.SubtractFeeFromOutputs.Length > 0)
                {
                    writer.WritePropertyName(JsonKey.subtractFeeFromOutputs);
                    writer.WriteStartArray();
                    foreach (int vout_index in fundOptions.SubtractFeeFromOutputs)
                    {
                        writer.WriteNumberValue(vout_index);
                    }
                    writer.WriteEndArray();
                }

                //Argument 4.8 (optional)
                if (fundOptions.Replaceable != null)
                {
                    writer.WriteBoolean(JsonKey.replaceable, (bool)fundOptions.Replaceable);
                }

                //Argument 4.9 (optional)
                if (fundOptions.ConfTarget != null)
                {
                    writer.WriteNumber(JsonKey.conf_target, (int)fundOptions.ConfTarget);
                }

                //Argument 4.10 (optional)
                if (fundOptions.EstimateMode != null)
                {
                    writer.WriteString(JsonKey.estimate_mode, fundOptions.EstimateMode.ToString());
                }
                writer.WriteEndObject();

                //Argument 5 (optional)
                writer.WriteBooleanValue((bool)walletCreateFundedPSBT.Bip32Derivs);

            }
            writer.WriteEndArray();


        }
        public void WalletPassphrase(string methodName, object guesType, Utf8JsonWriter writer)
        {
            WalletPassphrase walletPassphrase = (WalletPassphrase)guesType;

            writer.WriteStringValue(walletPassphrase.Passphrase);
            writer.WriteNumberValue(walletPassphrase.Timeout);
            writer.WriteEndArray();

        }
        public void WalletPassphraseChange(string methodName, object guesType, Utf8JsonWriter writer)
        {
            WalletPassphraseChange walletPassphraseChange = (WalletPassphraseChange)guesType;

            //Argument 1 (required)
            writer.WriteStringValue(walletPassphraseChange.OldPassphrase);

            //Argument 2 (required)
            writer.WriteStringValue(walletPassphraseChange.NewPassphrase);
            writer.WriteEndArray();


        }
        //WalletProcessPSBT
        public void WalletProcessPSBT(string methodName, object guesType, Utf8JsonWriter writer)
        {
            WalletProcessPSBT walletProcessPSBT = (WalletProcessPSBT)guesType;

            //Argument 1 (required)
            writer.WriteStringValue(walletProcessPSBT.PSBT);

            //Argument 2 (optional)
            if (walletProcessPSBT.Sign != null)
            {
                writer.WriteBooleanValue((bool)walletProcessPSBT.Sign);
            }

            //Argument 3 (optional)
            if (walletProcessPSBT.SigHashType != null)
            {
                writer.WriteStringValue(EnumConverter.GetSigHashType((SigHashType)walletProcessPSBT.SigHashType));
            }

            //Argument 4 (optional)
            if (walletProcessPSBT.Bip32Derivs != null)
            {
                writer.WriteBooleanValue((bool)walletProcessPSBT.Bip32Derivs);
            }

            writer.WriteEndArray();
        }
    }

}
