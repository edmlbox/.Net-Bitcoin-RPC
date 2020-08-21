# .Net-Bitcoin-RPC

### Bitcoin Core Rpc library for .Net. Covers all commands. 

Table of contents
=================
   
<!--ts-->
   * [Installation](#installation)
   * [Core Rpc](#usage)
      * [BLOCKCHAIN](#BLOCKCHAIN)
      * [CONTROL](#CONTROL)
      * [GENERATING](#GENERATING)
      * [MINING](#MINING)
      * [NETWORK](#NETWORK)
      * [RAWTRANSACTIONS](#RAWTRANSACTIONS)
      * [UTIL](#UTIL)
      * [WALLET](#WALLET)
      * [ZMQ](#ZMQ)
  
   * [Dependency](#dependency)
<!--te-->


BLOCKCHAIN
-----

**[getbestblockhash](#getbestblockhash),** **[getblock](#getblock)**, **[getblockchaininfo](#getblockchaininfo)**, **[getblockcount](#getblockcount)**, **[getblockhash](#getblockhash)**,  **[getblockheader](#getblockheader)**,  **[getblockstats](#getblockstats)**,  **[getchaintips](#getchaintips)**,  **[getchaintxstats](#getchaintxstats)**,  **[getdifficulty](#getdifficulty)**,  **[getmempoolancestors](#getmempoolancestors)**,  **[getmempooldescendants](#getmempooldescendants)**,  **[getmempoolentry](#getmempoolentry)**,  **[getmempoolinfo](#getmempoolinfo)**, **[getrawmempool](#getrawmempool)**, **[gettxout](#gettxout)**, **[gettxoutproof](#gettxoutproof)**, **[gettxoutsetinfo](#gettxoutsetinfo)**, **[preciousblock](#preciousblock)**, **[pruneblockchain](#pruneblockchain)**, **[savemempool](#savemempool)**, **[scantxoutset](#scantxoutset)**, **[verifychain](#verifychain)**, **[verifytxoutproof](#verifytxoutproof)**


### getbestblockhash
-----
```csharp    
  BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
  
  Blockchain blockchain = new Blockchain(bitcoinClient);
  
  string getbestblockhash = await blockchain.GetBestBlockHash();
  
  Console.WriteLine(getbestblockhash);
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "0000000000000000000560f1c95e7ab5857d37777f9c34015c99293fbe3c0d36",
  "error": null,
  "id": null
}
```
</details>

### getblock
-----
```csharp    
 BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
 
 Blockchain blockchain = new Blockchain(bitcoinClient);

 string getbestblockhash = await blockchain.GetBlock("00000000000000fd38c98aeef2f981a9591375748c2bb09b043be251d213edaf");
 
 Console.WriteLine(getbestblockhash);
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "hash": "00000000000000fd38c98aeef2f981a9591375748c2bb09b043be251d213edaf",
    "confirmations": 4,
    "strippedsize": 63348,
    "size": 111897,
    "weight": 301941,
    "height": 1807962,
    "version": 549453824,
    "versionHex": "20c00000",
    "merkleroot": "23f8682347a53b41e6f54503302bf1193b17036ee9edeb28539f20ffeef634a1",
    "tx": [
      "45fc5d4375be80fe1a2a8bbe6dc04a2923a29e967466db5736763c1c57217e59",
      "6c74eda133d5356a648507ad92d2a76b815ec0bc4517dc1840f50585b5db2e05",
      "ab6d91aee09a9736710eb8fb3b56e7925aee614ec438262bf2e1433b9423d299",
      "5407f54b04d75c35be46023c28b00ee3194ffa23c12b33e6e0293de2b00e8a15",
      "cdcbf95127282fe27157bce4f5ae6fb3cf9e6ac92e5c33f20bf16855559995bd",
      "dc9c8ea2d452ac7709a3bc7aae7ddfd5482854cafa1aad66b3ced801950450aa",
      "deb602e0ef753d1bafe9e85e5c93f261fc4749f01767165c70a67257cfb4fc8a",
      "c0fb29b1aa16861722b46dbe54402e6ff06ee71443e99ca26944126f97f200c2",
      "b48fc57ee57254566faef177787a4ac27768a9e497b10aa9b804d7db20c9fea9",
      "db52bf7472c94a98f043691e6da2aec3e81631f9f2f9d6351facee812fb24563",
      "e2702bd291e083d030f7d40a0b09bf68e9c49c5bf387fbc9f591dc5db1081ea8",
      "ddfc4fdce7d12398bc8f6698c38667f0b6728a9d643a3f518ff53ec4a1cc1681",
      "89a782776a502fb5ad8a74a7332e2f70d519ecaf6dc85806e21b7a234ed0b4ba",
      "6f0cadc67797c695b13b4b862c4127f7e80e3176642d43cbfa555dc4d75bfdb3",
      "b255967722d49982f6b0746c857a37d1f631553c1e5db9509279cf0f19ee8a44",
      "19b8bff51b6617af7434082a13421f3588a62a978823e6237903ae31f2eb1709",
      "bbe4e3ff04353147e33286a61ebe34684ea368ed529a985e5f2d9a43035dea7d",
      "f5f79f2f2a6e5b8b93e1c4528c5e54323b8a3a55013a97b5b1f07bdcaf40cf0f",
      "e37612e8795bc4607f96b98417755373e5e3e3dd075293c4a0506fcf9ce5f74a",
      "fa53c8cf45e49ead56494caf9f39c9f7417d31a28ac3d7b322c50a158fe6055b",
      "27fe48b44b55727e53466ff0a229734b1d58ad4fbda01ed70c3c155d975ee38a",
      "10909e7b838fbe4dc82a51682c972c37434b09199e6b616ee1258f16b46a3984",
      "f6355b3a79a792ecbd40aac5e46ab091417432660b9dce2a947967f66ab1ac12",
      "63fa500ca5ffa9a032eb486b81a2ed21d3ced21ff928a4116109f8e5ca1b5edd",
      "62eda2d0259f06680d545ddd5d7678cafe8776c360d808d7ba1b13ae9519cf31",
      "51987c23557db4ea2f4aca692ec50777ead16cee1cf934fc8e6fc4017116db24",
      "299c4a745d016a53566d3bd5c3ecd971d8c5e9f016b5c8b08ff5e7ef551a73a9",
      "3dd2bc1f89e61b58df01087b0ea07a0774101592ee5fbe8c5f7d7abbbe9f80f8",
      "bc85b5154c3306509076a168da776e5bda4809fc751ddacc7df57c66ec00055d",
      "6e887228c927b732ff5d97f4e8fd2bd8eebe9e21c9aee706527afe662b57682b",
      "bc9089466165afe887b710dbde842e8a45469865d06bd20959966a6c51adfbda",
      "e21f0703ba278359dedfd85f8174c7697ae64848af818c3b20210a498cd6bdb3",
      "3555054c121448c0f8e3530d3862c60d213eb649478c550413d6a28db52b23cf",
      "da988c695918ce605132582d076b4e7dd47242772ba023de9295f9f4e17f6a75",
      "b8376657c7f2c6b7e68f015fd59ab923d3261fb03f4f6f17388f8a703352d32f",
      "e6bd41b51a8a23f73fa1741c2f682e5ef47e6a57ff08544fadfc86b2a8753093",
      "4b9ff42d045633698222320d61b73b78f5af2f36397550a20f0098d00a7b553e",
      "f81da9e46c5d530d40c594e9095de469e8632c0805cb20c23ffdcbda6504eb47",
      "4e4bf42aaaf71a91071871410e8208f36639eea7613fc54b092d7385bf0fc162",
      "5e124302e38067a578f618c9d5da202676e4b81f0ad94f43c33a8d27f4d64ab1",
      "c03f858b4da50f913229e47b231f7163a909e370e931cb06c2cb84df3e88fe89",
      "01af9eafe6622f8a2696c6efb7d02df5a64269a2a2784df9d77ebe7583f6cf68",
      "2eb719eb80650827d4b216affab6bfed6365f342f01052e07370bed03fbd3ba9",
      "81aa9b07a7f69509109ad182d9ee89f1719c4c2f50f10110584b44dcfd900d7b",
      "78fdf8b4afc59cae4d72253a1143bd38e870c0086825b158c03675ca0b75387b",
      "f49beaae0a24e5f9ac80749ab718f1fde7a92a573078baeeca53e1308afe95f0",
      "cf18d3182e77d0339b80438ddae0eea9d3161295b3491742017d867e498d4ba3",
      "7b68101ae9b47d09c6b12b96e8aec22a5ea6f555dfd4fc3db33fb56f88ec4d7e",
      "1ca773d6f9b16669fc22b287dd08a006f318841760be1cee25f867c2ac43ad84",
      "c6cb956fc5bc67781373d172fd009a8cc6dd34637fa63875939287c87a9567e9",
      "46c51956d3f003ab96b0b3852cade77918f41b5e04b3560e16e4a3f59369b087",
      "3419972bc5694af9b4fe55bd297fd6c3a9ceed3c5937cd913442c7aa6726909c",
      "06b9ce61a659c61d31fb4c2bec0a9ecf79031abc7a23628f6a09261a9e3b46e3",
      "5336fab67b35c8a4658ce88850bbe42d297cdada79c558abd43a905eddbb21c6",
      "732d91e20b195dbe30e574c519031751107fb4f02eaa8a30399742646055bbd7",
      "1cd08069973731634ec42dd0261c5b054de5f97b7e53a4567d679ed1dabf6ed8",
      "23a95166f6335b411931c4f812465afb83e7eac4abcefaf1807325820914a3e5",
      "5279a740b84faa0b7635f4ac4260690e2bae24fb04b08704939b7a210e7531f4",
      "43a2b7646fae062fe0c029c8c5acf1bb3ae687c1ae903bfa0d83980c6a470b01",
      "f8aee837b119a4f6fc8a8b6a0e30f8cb7d8cf3ce10b13b54d1d9a630a876556b",
      "46f31c827802870b4d237b92ae177ea9d7e24c476f34bd487e287c84faef98c2",
      "25ceda482bf468ee8c966aab2deef4725f299324d043e1496a5090fb46828d46",
      "693a3cd799e071ac82a317a73b74e3cb2c016a994f4e8a90cb92dde2b1209334",
      "05125e658ee2313957917b6932fb07f0911df2a0d31ae77da555b43ebb6d11bf",
      "00e9094ed656e26f341950fea3bb4531bc27a40a6831096305f83ae90f6998d3",
      "82e16e59925f08c7aaaaac4fe01395172103123c17fb0644503d9374058b7ee7",
      "8685ebdd0b6383f4f39f279993c12a6a6b5c47a88ad05adcd34940a685559bfd",
      "aa17de3a4f821e0311bc12db637b93f8fdf136f94768c884b1f9b313c9cb4795",
      "b86480f15368dfd2b963bfd7e25b5f1f384f9257adfa9e1fb71812f72fa731a8",
      "69fa7835be4e9cc1b1fa2b156493fcd42b5acddd5800a312f1560aa599a6e0a2",
      "2e7cb8fc6cd1a6903326f908c27b19707a7f5fdaa8ea369e177643b61aac112f",
      "6287d8bbf58e09e40eeed254f2f116e50916bce693b9c065c71bb345ce355b3a",
      "4d50c3ccab2710d016851b818f7a1fabb2051120397e66634384a47d5d7a6180",
      "2ace31f94172ccbfded3df27ecd75116a8bd58e6a8fa70513206882d02754822",
      "ccdaff61da21370f0aada650c77c04a45efaf942113ee61a2e348b2c49c250b5",
      "c86c5743aa64b739441410b023d1e78c11e10e7cf5a97f0e786d0c3b9e1d20d3",
      "d42e93f8a24ab4ee966276663cdabdb8649360ab4a364efdcfe89205516ba01f",
      "a18c05ca765ac9f21b7ed0fa6d47b5396140b981bf212cb0f19a8486973a9d37",
      "ea81af5fe78185bbfcb6256d5e004416a6ddbf3747a6e29467a731be77c27119",
      "08aaf4a984b158169fa098056136e2e7971b1d416eb4ca95e0f9ca1790c133ad",
      "667409ec5aca139feac6f0741c2bb256c34b6ef2df322254f0e03496b0ad1367",
      "5032b4125356a2aa4b1412de8a34abec76ffbf056337bda457c7c1fe398d7dbf",
      "c958ca99b47a3727106019fcd6852f3d00a6e4e68494293409adc149b3442938",
      "fdc01edecf9aa8e61333217e8388fe75de3d82a29f8934c0ba273cd5cd89ce64",
      "3ae92cabdad4adfb2a4f41be37d047c46ba63e34a19624e10f880b5a32c6e883",
      "2e3ceda23a5c0e7e488b01a0db049c2ba4c36f6ac310da23fc85251a72e1941e",
      "f1b4f91c76bafd81a7d6a631d1280b7a79d70042f33ea229f6827fc593d137f9",
      "c48bd76f717f6af3ab5a4cf177c37bf8b586bd792755fdc24c13bd148c53eb22",
      "ddf464f3d520e64ba35db3412575ed87ca76ef6b8c5efcd5b6bce8fcaef84a8d",
      "8e50eaa4029e525e3828ef3b5a9c14b159a955eb0eab41661e100b0af1081060",
      "fd0146484dd3d5236a95a31adafbb5f7a7d623630216447624c6efbe1b81a965",
      "4022f6b3e4deb7b75f57fcfbb562d94842e91bb474b796adea20cf3e185a1245",
      "4ad0dc8c6d0cb2898bec7a24ad3045ec8ec181373e8f83668aed912d8a51ccdc",
      "870b50180b08bd4670e1abab44bc8c09bea91c9727d02d06c7431f523c7542a7",
      "66a8c0a39f59784f8e392c583d42669991187760015ca64b74c9356fe3b9a45c",
      "ed863cac8ccf0a48e82817c90671100f1d199831aba548e3c0f357f4750f89f7",
      "f104d3f6fe20a711a5f9c9acad6fd6aaae4b82633cee9d5ecaabeb7475084bae",
      "360e6c4e70478120fc2444064b15b0bbe88f21e80f82e3dceb8c19c1bdc7da14",
      "79098e174f0854a4efd3e09a0d834b027102e058c9033d258b5e8b123913971a",
      "79ec8d94e73944a76206183fb2175c0bf4df61975d5206ecb614edd59318f11c",
      "bf46e73b2a2fedd4dc05a4ccc033bec393522d704178116ebc18a3d7a990fef3",
      "8193306d235759f52552fa1bfa8a0d41350323f86159eef5d269e13053b72ad9",
      "e7c840273f407703c8c3fedffd6b75a563b80bf31a704c5ab081b4672fe39e35",
      "91e132c565bd5d5534e2097df2b29459a4415555f1e17322eb25f917bd2a532a",
      "b6de41b43b0c7ce5d3419a2e447d93c51f0d4971d49b31d22aafa5c526f3f9ec",
      "b19ade46cd7d1d502ea9c8d31dc0a17c69be5e5f3a8260850f7a2f79ad8a5659",
      "ce1b4067aa4265fc04725cc6ce2402485efa30ffb0559fbea4e33a691d466488",
      "68055d0e075a9cc217c0d315acdc3e5e60cedba25f4d9c8c21e542daaf0d2eb8",
      "83df2a386d53739daa0afaebfc1c826b1fb3b180ab4acedbac9e509eba75fb76",
      "e874100a18c80dae319447eb8ded63eea9f91f12140619e35aeb976056d1dd27",
      "6adce42a429f36bef90b2e2512f7205256805aa2be7bb6029e1b7ccfded79fa2",
      "ff384147e42e1cb956eb1ff6615d507efa63619487e5083873b78173b1fd1abf",
      "4699808e75f586fef6e78b39de18b8c49f5c461bdd46de1cdaebb00857717aba",
      "c225d333e315a567d87f566061242832f331bdafd7657eb55c8d0aeff110fb32",
      "a39e201f4af3825993e0e88e88996d5de1d3358f10031ef7ed1d2f711254ca00",
      "13ebdde34090a63e403a5603b2b608dc8b92a7dde187e5cfa5724766d721d700",
      "4eff3f0136aa4ff743de537e59b6b997b0705ba0a619dde376c409a6d313ef01",
      "592d4d85bfa1ec2b3cf5b3244013db08d554e4faf2b363f2338c752d035bf901",
      "5334efad479931894e682bbc7ed3505507db375b645f810f3e25cb70ac313f03",
      "cc5e9cac17fdf26edc33d1ccc7d07a2da7cdd04d733f12b59f86e8f833a09e03",
      "8b2aa49cae751be8a41a49ddb1f048dd123a359bbba6faaf6f84df7ac2169a04",
      "f21ac88dc4847dee4056870709afe6bddb9eb01fc1bc32fca345ff8a20bf3605",
      "a9210e894551666451e7d423477dc29d3a847475cedf3ae44566078e989ab006",
      "6be9fa87d2dd5b124a31c1bd58e854268fbe4d91729b50d901720d9693a12007",
      "d042dfd881dd507357cc018c99fc1607fc32e7f26d56b59aa7ae635e0e9b0408",
      "2629113355f0287af2ac53cbf59bae49bdf14fd4e0ed00b2a189fe44a8791908",
      "2b674a91aeab62b9f6b2c7b5118283fb3c98918d6c9d3bde1303b6b8861fbf08",
      "b021a10f3bcf53633a13892e1d2340e217c88011b9fa9c8dacf427d0151b0f09",
      "000864b9aa41f1cd4e941b06233622f9549c74ead2d0118e0355b34f15dfa109",
      "10a5ed13c15f64f3f3e2a56329ca594bb88e561f9d1c99ea1e7114d5bf75410b",
      "8254c2cd6f6bffb6780af188e921ed0c4319d2fb8d06473cd1d3edff779e820b",
      "b1fbcf1bcc3d15a20c8366e0e6e7e7dd378e7edc8d1d641e5580da751646840b",
      "4892b781c1c1a1f199471c3af936d9c23be4793a1ce5d0669212e4643093490e",
      "61001627f7a76481602c74a296474bb84c5da2522139c51eee26752e8474f60e",
      "b0e94cad46dfc5059a43830c9056a936bc81e083dda7b52bede5dc8222885f0f",
      "176545d39cc1d5b7af0d210235dfaa646a187878b4d357e334f0f821338c6810",
      "5b0f3a0bbf99fca088b8e46ab22e6dd13c724db1d2a053f2f04253dc91669010",
      "6f6653f2e5acdb1accf248010a6beb19bf422e1b49aa213817c1eee331ee5912",
      "46c1227ee88cd46f951fd99231b64a792f43c32267413b1e8c6567459199fc13",
      "869ee925cf52ff291940cf6aa9bd6d9cf0f1f9414c9eaee41e057750a2323214",
      "85d1e45c8e38de9ce7e411eee8364eb0a66a63aff9a1db1c63ba0e49baaaee14",
      "59c101c31937f2d0dc666e5a2241fed46a231d17b0da1759e8288c7049941015",
      "cae1e481885f723f680bcd40998325bad01a72b4de12b0c3cc8c34cb13c70c16",
      "138c6f12aeb014eb388b85df53718ece317f974f0cdc255e0c48d70c2a3e2216",
      "d81c1726be678bf36e9bc396e09dbaffbdada3312dde64e4dfdbbc696e843e16",
      "da63779e516ac399188f7b98a5ba5398a9358f6f2ee3c6a7036e66e8f6b04b17",
      "19d28da51e1a9105ba9c12fa1b3ee9a0d20d74db1c0415f9028e10ae33058717",
      "3852e378a5033b9af646b4342f408f4fbc95c526db832573f843fb00e59f9f17",
      "f17d74fe5c111e1b44c3c9cae0e29e1dca6fb9fdef2ad57249377f468fa92e19",
      "ad2123d064d81351f50ae7582043d3394ed3406d44e15d45b8ecaf6aca1ca319",
      "a6e91eee4bde90d33624264c2b713556dc89c1d539dec54728fac2e1d278f219",
      "936d524f8d6efb47f20d6c8cdb28c4f3903f7894f37153dcaa6073b2520b521a",
      "d14b5578ac859144516bb7527fe0cc1be4dea454376db8f86a2ab4d89bf8591b",
      "51ca7575b06ac4761d5614ded9434f4f7615d0b6126448eb31d28d3e428d531f",
      "72461d778d6b5dc91af059335230b415848a7888362e060819679d6e67f2c620",
      "b0e90b4dc3afe2ed87cb61fcafe54311de250c1d5f6eb5e367259912f8268228",
      "b281a2fceffc04ce1eed05d6f475b6d5db9f192afa73191f6d34c2b13933c52a",
      "3001b7e2c1aa915f5dcc9935a44b955a2e1859b2146f3c31343c126aad93552c",
      "e99ca782558131f761dc67e0db3933423a290925c460e6a469e0a7d82123092d",
      "59db16f42d5702fd087dc684ea93d0283f1d7f70c615b497e9cf95339195a12d",
      "5057393e19d2560069e4794a3f918bce1d9af1e8d893213b795d6745e8a2372e",
      "1f9acbdc1452e3774bc554774826cb690895480591907f653d6f041872932f2f",
      "749ee895f88cc7bc7d2cc3240de57714083a011866a18b8885cd1494e53fad2f",
      "4e73ce9a270aef840ce0e4a18fa17e007ff0873100d5850b2b43483e379ee32f",
      "58e34d8f3de5233058fb8ac4965388c0069974aa3b3d1cb4dec7cef950f16531",
      "aa82213e0e62cc07664dca6976f98c6345dff73503af25191458c8aaad53cd33",
      "38f40ae4cc8dbb40cbf453b215ae38b8c6544dcd1b55da9206725d446a72d633",
      "dc655fda36bdc06ad2e8ff208e6c8da50f85062f471ac3b875b3ed66a9829b35",
      "9ea54308c2104b7e713ee36d567ee979e33132598f60d0ce991831315e4eb635",
      "aba64a2ca6d620a8ddfa45214bb543ca5cb707d54053e63356f125193adfe839",
      "00c3db38def18174c7298db492b8ad8c253d79c577764c30ae4a2a5d8e6efd39",
      "a0d826c45f2d585ac70046cf2ba0931478e1e4a123839480bbc79b0e8eebc23b",
      "55691e54a1800bbb6083be9887c67f0880292a6a1cbce4af2ee399572c62063d",
      "a9f3beb756dc7fd246332e6feefdea55b1d47e68d9a31328ae808794e731e13e",
      "b10ea9e1d56be86c55459cf71fb8b5ca8dfd53147aa5ba63ff4af13b22f0543f",
      "c9e34ce7eac204d76e1f7afe2c0d1cad8d32a53d69d7b120940c98d0e4934140",
      "37497cc78029b10b0247afbdea25afc7a5ba7eed14dc07292dc525765ae09341",
      "68ede0760878dbc637dcccf5aeb60c02be3830e1cbc695db0a5a72d80fd3fb41",
      "f55efdeab89bfeee97817c2786cd18320999b5b30ae2faaa5aaa966ef6a07844",
      "314a5b0f050b59a341c0dd11d0fbfa06f58348e7cbe58fc88a102c36efa34645",
      "7bd29d6a1c7d6ad730c5fdc170e17b7ff77766714fee37158f88e91b9a594f46",
      "10dcb6c889160d8e9f874382716eca1b73facc7c9ef482335bea51691e1b8c47",
      "f98f8b6c9b80848f3084b630a35471f32bea72f0f6bde03c60fb633f1cedde47",
      "a5fd19282c2aee4f63bd0b36bb9038cc04b1b8b5612eee25bfc7f7caa7938d49",
      "526305bee9ac01e6ad6788320c06b9cabcb963e7e27b8bffd1954331fb60284b",
      "b0fa0083cf54096b06d66a5daef998be10a8ed23936931f2982e239a3c94524b",
      "558c77518b6de72088eda19b593e5692ea0d8addfcfa7e075e27046023e7bc4c",
      "2d3d0dbdc279400317a7355d239e0b48a5b83dc4a79c574ddef1169143f98a4d",
      "5b6003d03d20931b4c2cea479e15158b383c28c848ec2763347787f429e82450",
      "c1c74b17cf90260ebcb710da526bc87c68fafed7556f6acabfd8530b89b29e50",
      "b5488204a2838458b49e06589cbfcece048a9866269ec05992befd323d71cb51",
      "1c967f14a9c550b4d77533576ab4281460b4157ad54ac76d6bfe602958e61052",
      "a31560987f0749c5e160dc78c3fd5aa1fb15774157a031116cc5b74fb5712252",
      "fdd92145021427101a665e469dd34ecef1b6ff5620a8b9f51fa1fc8ee2976f52",
      "ce6c2c887efdd0714600ef1e365f8fcb42037d0153e6cb5f7b760ecdbd629753",
      "123e4781cd4ef3e6df7e6f4b68508d2d11fd5ac57ba7c4efffc8075b1266e953",
      "9c7bead0b7ff5c3d813eb9451a902ea14e293afa4dc8c15e523165e795eb0954",
      "8528fca03af412ff15078c28645338996b482d204209ea8598074bc2ecc55554",
      "f79b9e327080c64e66e7fbb1139c8d65919241bfd635bd0566ffd426725ff154",
      "116fa631834103d5d1317d5586b6679db329090e688d8c21a0c0ba19f79a1655",
      "7618b9b2a30b05276e42e7ed78fecbce3028577ca3d203ce7ef6931023478655",
      "7010bb6bd107c4432d22451d679f454863fd84829b0bc0464c9aae180b72ff55",
      "4b9009e1d52cbf97eb2dbf0efa9eb050f62a783edb4a0590e893400c26886b56",
      "9885e56ffc1bd4e0c8b7be27c8582711cf63163d9dfbd46579cf2868c0c4d956",
      "9291bbb0baf9c6594a56b2dabcbf217fcbcb9913859a9fcaaefdbf1edfae2d58",
      "e965ec54237accdcfe07bf0d9e6804114952990c7e1fe1ca5c3795a9c88f2d5d",
      "357f4977ead442c02dda0db4a9e389c12892863255db51737e91da3be2ba135e",
      "d9ee53c17e8c53493dea3bcf05f4b71bf5651ff7957e5535d2250f6ef2d2a35e",
      "0d55f2fc2dc667441784b88ac64d862eda494685509c7373daeb49dbcc6ec95e",
      "33a495a647459ddf61fb795e2edb8a531f2bca1aa87cf2718f01be8b9a6d235f",
      "d448b6996ccb0f7d57ee67bbcccc005685ed10944bd49079c279bcec07cd6c5f",
      "8812051b9b7e4585e6f5dffb70a3a324ed1488c8875d68c9eb81a6229f582b60",
      "cea9aebc885444c78fb9163ee07b6e096a97383c684ceafe6767530951eae363",
      "5d5e740a187784175ad34a42784e785cfc6f4c38a02ee479bc78e4316b7afd64",
      "905a7075d0fcea4806f874f68eaf55737d61baaffb55c6369e44e2f090d52d68",
      "65dc5ff1f96d2d6a094c2d7059d237d7660248ee368ec8feb5aed6e5d9f1ee68",
      "17d126ab4163d03c4231f3c6a52134442b1230d83488255bcf02d70493de6b6a",
      "7241044fef1d0a29472e699f8f22ad2ea87092979623e89e059cbc7171c39b6a",
      "fc12e422d46ad4b0974179cc3950a599229aafca530b1322ac416717ea5ba06a",
      "675baa5a0ae7018a2b4ff59f3b24dae5958994253d81a4f4906499492318cd6a",
      "f8d0fb0a6527502ebd77d1f1ee8e826e5bdf83621b35c196c1711d2d4832186b",
      "e7aa42a5c3da2a653eb358fb16c703dd42ccaa69ed77af5619cc69af4d06a06c",
      "77ca0b4496e2f8f0287ec198065b83aaa8b0f7eb0242c00370728b455b3e6c6e",
      "87210c7069ed8bfd3b306107eedd03e2505b530900e25fa6461516ac049b3970",
      "335967b96b52bf5906538fa88a39c09f02820e3f331ebd5ac69b4fa81eaa0971",
      "51ee55455988cd7f28e0587a2953f37b330640d4e130be76024dd6321f129a71",
      "755d9bac19cbdc4390fa9c4e769da051092e74d3be13644714a5bd70f2dfe672",
      "9b593dba2ff9d0eab5c39634780ca10391cf2ffae88f75a3c52a621021b18f73",
      "14eb2e9d104aabf2c9656888bf78d85a7437c7d4e63b0d7f792b90fbc1a1c573",
      "90b3f942c1a1226931389be011d81279d2b1473ec54309ce61964d156a4a4074",
      "6bc808fe3762e12ebf4767d5b555378f9ec9f7edb42aac94da485961bb200376",
      "c500a7e801172697992fc4b9cefb00968ff9d73f397ad65af106b27bc8800776",
      "483a09e8779be2a353b6b7bb1df08b1668d293beac02d86498f6e605e1404676",
      "9e9bc89f95adce55d6cbcdde3e575c466b9d2a4ecf785bb3b593f2918b0e0177",
      "b4d8ee4fae0a85906baad4520baa5123c3824fbb782a6ec6b728cec8ff9a4a78",
      "2578da5b98191f23470d276a53c70616ea68acd3b8b37814f85e425443ad2379",
      "a2379cde253c9c03b819f6536cea1ffc997aa48859fc27dd0b8989da5b326279",
      "f8c5b8d220f14c6c32b19feab621e779c2bc3f7274b3843794b0f606760e327c",
      "c6b3fc37327479374f2cf4146943420443b73c51b86c6375536a2a940e13ba7c",
      "2ce28c71c018dc6d2e95df6b89f694cdd3e19402f378e1c044841e216dda437d",
      "ae5c005b452ae78c75f7c6ab0e6ad7b0f87fdf4710e23ce8395bae8ae421087e",
      "cc2f1b83cd74adf188dae0d34e1f013bf8a6aa73c3a4277dbe345855130e8d7f",
      "993c4860897cc54b040094b14ffe0fdc7082c53d826a1b852b90892185393780",
      "338a984a7f300ed50ed55963c4eaa2fe3cd27d87d7b721bb805e1f86456a4580",
      "dd64f079acc5ca0f4693ca38c6d5092ec61969c335741b5b83b320c4b0821382",
      "0b5fea1b7e6aa4ab85345755d339384caec26a3fcfcfa91bed145025690b3882",
      "3baa29b1cec8906d30e77ee93f3bce6900e8c64bb4c1d33d31f50aa802f2e482",
      "4aef6cd7c52772b0bc8a7c12cfe0a934b4dc3f639c38dbfd6adaed4269c1f782",
      "858bd1f1b172920733c1b2b25cd26924ab4bcc2ed5fa71bacfba20531d753d83",
      "b621d7cfa68b0dae3d485c0c95bba573da12b1b6ebd83366cdb49c102b7afe83",
      "0de131149341bbeb867296f978285bf3a02e8b424375535f9bae50dcd7cac284",
      "9adb3106956b17cfaecce00dc0c91a509724ff595e2dbc652b1ff1fb7ed3ea85",
      "6bdf19286f511bc01fcc675c4fd3cb5640b2dbeea581b2b4e3c0802c4280b287",
      "02d791510921de13c0e87aecb1e654ab3858d10915a88cd4ff092c875ecb5f88",
      "ceaea1818c83e8c2a65741ebfbb6c7b48d13f2eb3c0244f1810ebb7fffa49b88",
      "8e4158946a60396d422bbbcb4a1f22dd84ff0fba18cb51d309ee2a2cd54bba89",
      "84468972a1195d746194ee6d03fe701aa14503491ea8f78bddf6de153938ab8a",
      "454a284047eb93db571b43b22c884bcc144264206b2041b5f5d27df404aa248c",
      "c9312b21ec7ddb73e7b2b929b67486b3308faa3a93e4922bbce294f24d25208d",
      "eafa5b1603c4baebfe6bd6e61b1d98119f2941c8ca3df836ac2913c53e100e8f",
      "58902dc59c9e09af7911f6319ff9fdb6ac22b25a0d204cf1c9067cc104368a90",
      "c36e5ea47964ad889fbd9886bd66a7774b99fb6cf3fdcb4724fba9221a7cf291",
      "189e1a211968eefa412bcd72f0b45c4ce4a8b415ac77340e671ad6d0e6bca793",
      "7de157b05d49e0233ef8fef5927ef1bd16e3d5b655abffb0a1b8fcb4b8054d94",
      "bdad4a76f5bc1cbe2e35a5b9426b1cf6e725858f1f7be1b19b920d50ae220595",
      "033f315bc519ac38fcae05ac6dbfc7c84073daa49bd58d747782a7432428ee98",
      "8ddbf8906a0f4db74881c7cf1c0ea68b45fff10d1d89caaadc210a342b290e99",
      "5df9b9b6203df555b604e24091427ee378ef68b1360fd6b7a0848eeabec7cd99",
      "2da90dc15d9b5d1abdda076c15964b21cdfe68d1e13cdf27760810ca9f8d1e9c",
      "83b2f79f2fdd43e44ac979366bf6d3bdd4109fd41ecd42350c54540ac8dec49c",
      "db46a2bba68d411d1753fe737001711e21bef0336cb2b94239ad40f8e23066bc",
      "706c2d66f79fdd3f12e7655bb19e64300a861efc8877465f94b463235d37f4b1",
      "9bcd17e573d6b36a0ce8743e702588dea8a09fdc8fe6158d63af61da425f799e",
      "e0e3c90068bb6cf18e60ae3c19017199fb4d578befd981aac2127056b3f9b49e",
      "aea793b49e54b09c3d0414d51144b39175f4445806b255a0e941984baad7c99e",
      "1e3c9e9deb015ff65dff00dc3e7c14a7ac2c97ff5095b90859318a317b8789a2",
      "342c9e737888741824f1f2c6d8516b6db7f248c5d373a3977bc939b8ddd5e1a2",
      "b74ada96688a74074fd49c3989e4562c9ca9f665234e8dc7fe619b09248c02a3",
      "2db0f0b87d932054be98d903133b0bab4d60386bf790b51a1fcd8da40c57eda5",
      "ffd0ccbf15122fd68ac8c1b5449538d60daf9837c01595081856e17e37b4f3a5",
      "ec4f932dc2a2ea44cd052f1d668a60a113223cd4defb77fdbeb03d9a52fe87a6",
      "f67b9e770755be774a087295da32219299d26469930bdf0635bbea977e1072a7",
      "c6cd2da83018651a95577d744d9cde7c17d3d07ba2f345e66208085497dc8ea9",
      "fae1986fd0a70a60efc914386c0be366be0926f59edc0d6f224fea2c635bd3aa",
      "3f43d5df2b066a29b6e404cc0dfaad944297af7f8affd521f044416e7da625ac",
      "a23298261626f807609330d64cba6d8796f061005d938977a274aafa375453ad",
      "944adf128c626d12e57e180e15c691a26023973dd90a4064d68463f2739a6cad",
      "1b27e9cd54d01e78456c1ebfc0d2f756e65ff0274a20346e4f1d6ad9c6ccf4ae",
      "f23a1e6647245b7125702d09c3321a99ca7603e00b39d86867853be771d258af",
      "fc2f5ce3a13321b06c63e218f01c00ff5bc016a48f7d6b19bc18c35aa4816eb3",
      "23deeb0f707f2199a75bfdae173ee26a8f2ec0f9874d9016cf634a6644dd24b4",
      "a5c1f34c46f13ab7e602a5e80ea7a64e9eb681333fe27db497d08fe60f7b59b4",
      "2b91f698292882f52942ff9dfc1b4cc8561c194dd2bbd5a5351df53b74b27fb4",
      "393ac9cfcc5bb67348c4e72e872356e032d8c3ef2bc794a404fde0a0391f44b5",
      "7e96a0ee35b8e42510edfee0f8a5ac284caba6f568e25439e7d0451287cdd9b5",
      "f9834d8a73d727a3eb4a3221df099160614030cd68de92690fc0ef16de5847b6",
      "fe45cb4b9d9e9c30d65a3060e39218faef6a5792cd64a1ecb257df884812c8b6",
      "1861ebcc24ccf24b6e14d7b3000914abb4d570917dc70f04d1bc044e92543bb7",
      "26c44efa83d95981e9b79fa50326ae676b5113c4d26a56efbe8daec8984373b7",
      "fbeffd2f9863dd84a43c3d9b30308d35e88cd4be88cc93c1339b6c49585d6db8",
      "c655c9c809469da38eb9d783b39d1addd2a3964f10713d0c7afabc895f3f06bb",
      "2bda09902dde85ae93f3167e5ba13d272d28cde73956c6bb6251060bca24d4bb",
      "e44a479a253557cf897e283ab7f299f93a6018f64fc9bf238b1594a2257527be",
      "96edadeeb4c3a895ed3cc3ee2de1d0968b1a87635dc6d78e92ca23df142c55bf",
      "8a3cd72a0b08cd2fc7fb60a94fafe6d00577b0f0a7fb6732a170f93be4f7adc2",
      "260929d063730e17c86eae6d27c5c3e910c4a5b8f8410194046470300d10c5c2",
      "a1adf00d28e63700232dce38211b567a0cac04e75862963db4c0696950c05dc3",
      "7c25f0b31561b35ce424a010b24f0105e2d3ac19fe2262f4bbcd1be69ee788c6",
      "67dead3311c67e8f90187fc8108b2dcaccfa41afe04caa42dd6e6a8965b6ecc6",
      "a23a1e7d430729e7b455d4735dd5a8ece5e7249fb3628ae297f8726ebacfdbc7",
      "67ce00dc8140dd9c29764255d872b4aeb4be0137de0c4ba1e74de92f48ae48c9",
      "22cc377f9282ee0fe7b879fb9e8e228106c54d04fc11c1ca73c91d0cb54984ca",
      "29d698fa9c3256e12c5b5a523a13547ef7002df270bcb40fd7b67732731c3dcb",
      "db73f301ddd27a42546d2b0e7a0383fc6ef01e060d14c2b5c01a873dd252a5cc",
      "fbe8744bacf5b883db8779bba1683f72568e80e9b093029de4ab90f2d79798cd",
      "2859142443318a44cb0ad778e9e58e474b9abd18c7fb6768a31a3a4cd0df33ce",
      "0c65c668b98ecfd2aa1e3843f7a4dd7e7b45dc181c0b4c341bad984d694e3bce",
      "23ebf13a14c59f5965a7e1f3a8f4606237dd000c42836863ffb20f2e8fba30cf",
      "1d64a84e2a19da3805eeeaa26e8b45e4bd26d5f27f612443e96b1ceef23570cf",
      "e17d56b36c8ff78059ed54817967423bf1a897aca2805d8ec72cde1ce731a7d2",
      "67a0267c5e28a0ade56c91ffb518c509a17a7f46177ea33ce8b99a3603370cd3",
      "ad12e54480906e77b5026b96c7e516f6ba8063dac5824fb39210159e7d0de5d7",
      "9ee8c3aac50235f94212e5409347c10741eb833e07018ddfc911129d7cf104d9",
      "61a2bcbc24a81e6577e0fc03616fc8edf95c159d938f6d0e89e3701a75072ada",
      "1a6f9cf75e233812c07bbabfeaaf4fe7a7de36658a823981812b0d3e50bf4cda",
      "dbeab4b786b51cb2809b40f21caebddddd20e22923f37335cbfab8fe797e67da",
      "55e233ac77f4520a0924ec313600c5af3b513c421cdc76494d644f8533dc9adb",
      "b7ee10c8402f4edfac1b3ff72798bab1a65b1eb5df4d39fc33c72b2f2639a9dc",
      "b28c311f6cd5eae404aedf6beb133a84a093907477f7c7b6a397c563f45264dd",
      "d5ffaf30d9401ff7dcd5353451d320597440954aac8b0824412c9021379bdbdd",
      "ac735273cdce1c550f69799ce9f1ef6d909fdce352c28381482f0fb326da24de",
      "c4379bc34f06c39c96d5a8d3e9e2cf9d1482a08176342940b4f5fd0e2adea1e0",
      "ee8b5c19ff1bcb693cdc9b8daa7540a4213c67697e7946c3fc2cc7eaa3a1f0e0",
      "440c7dcaec3cad206631a5982ffc8eb7a3dfba5cb513ee7071c432c8b5746ee1",
      "9e1437be167a5a9ac3f26a4087c79a6ff3f92910059570ac4ba34dfe896579e3",
      "0e65751656a7aac59755f1b5070c4926352273a96e8eaef66758b73f8f97f0e4",
      "546ea40731affcb1dda930238cd21e69d9d3721bcc37fc471ab656d450e095e6",
      "bf4acf494e0bd3bfee01a54eaccfdd85953fce64b7d8db0e1a2136c27465a9e8",
      "c52254db8d09480997b433006617959906b3e0a202bcd736d52faa05a015fce8",
      "fd79ca784edf82b1ee2e193af800cebeb79ed8b10318e3cfe6575c2f957705ea",
      "23aecb634911d2a93bf67db4e66fd7a3508fdbaff8ca42522b550bed00658aed",
      "3118c9bd94b2f27a6ed339fe5248da7c59a4cde96546744a40b5bf51b206d3ed",
      "d11b647c0c1527c7c14098f7ba88790febba95c9221bb9916973305416d60ef0",
      "68a10222be9a3c48b3c88efe9ab09173031354e7e7b1fea0b7ec2f1b3ccd76f4",
      "56cde7794a9897adc40222b3d1721241b7f9fc9e04be0f5b2d48c6a51cbb25f6",
      "0d4ded15aa5a752570b667391731f1e3b53d86e7f1a8608e5f23ec6d46849cf6",
      "f87fb3eaec5356c1db531998784190433ec7377ec2d744d356540342e976acf7",
      "ce434d4b8ff07f6daf4e815acdbefce2064104011982d76bc1831a8b79fee9f8",
      "ba4bc9e7a125bac0ed9ab78d0454ad101479625dcf8d4214ee12cce51d9b9efa",
      "6dbf7895a8249d7d9ac41ef60d48d91e59a7b694ee01463dc490c21934f289fc",
      "47d0fb94eb1903dea5792cce9cec70d43f2ad39b8b5ca091454dddeff19ba4fc",
      "0cd10bb39da1228638e56d8621d7192d46db91e963e5953ddc4a3b697814e7fd",
      "649c8bc2629fe09348b372833a92b4917fb92a540c4b45b76c9145829a1732fe",
      "6b02595330bcdbdb1adbe2736967e62d9d588f658eb57232bbeff3e5017192fe",
      "afb18d0a1d108f88d9a91dc51db3fb24170c0a2957b68055ffd3a67760153fff",
      "82a8a72be1823626a8f4c4bb5f0a686525afa90521cc9b04025c94f98c8772ff",
      "80b96638ab2a7c9e58318ee143ba38a8505d2e479fdbdf5111553c8537ade0ff"
    ],
    "time": 1598003003,
    "mediantime": 1597998014,
    "nonce": 785429816,
    "bits": "1a0151da",
    "difficulty": 12712392.76864377,
    "chainwork": "0000000000000000000000000000000000000000000001bfc249400761d235ce",
    "nTx": 357,
    "previousblockhash": "0000000000000063121247dfec7f057f0bf3ec54b520ee519e84c1f99dedcee4",
    "nextblockhash": "000000000000012da5c2fcb6c72523301a15319dd8d8469a6b298092230972a5"
  },
  "error": null,
  "id": null
}
```
</details>

### getblockchaininfo
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockcount
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockhash
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockheader
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockstats
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getchaintips
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getchaintxstats
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getdifficulty
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempoolancestors
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempooldescendants
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempoolentry
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempoolinfo
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getrawmempool
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### gettxout
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### gettxoutproof
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### gettxoutsetinfo
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### preciousblock
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### pruneblockchain
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### savemempool
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### scantxoutset
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### verifychain
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### verifytxoutproof
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

CONTROL
-----
**[getmemoryinfo](#getmemoryinfo)**, **[getrpcinfo](#getrpcinfo)**, **[help](#help)**, **[logging](#logging)**, **[stop](#stop)**, **[uptime](#uptime)**


### getmemoryinfo
-----
### getrpcinfo
-----
### help
-----
### logging
-----
### stop
-----
### uptime
-----


GENERATING
-----
**[generatetoaddress](#generatetoaddress)**, **[generatetodescriptor](#generatetodescriptor)**


### generatetoaddress
-----
### generatetodescriptor
-----



MINING
-----
**[getblocktemplate](#getblocktemplate)**, **[getmininginfo](#getmininginfo)**, **[getnetworkhashps](#getnetworkhashps)**, **[prioritisetransaction](#prioritisetransaction)**, **[submitblock](#submitblock)**, **[submitheader](#submitheader)**


### getblocktemplate
-----
### getmininginfo
-----
### getnetworkhashps
-----
### prioritisetransaction
-----
### submitblock
-----
### submitheader
-----


NETWORK
-----
**[addnode](#addnode)**, **[clearbanned](#clearbanned)**, **[disconnectnode](#disconnectnode)**, **[getaddednodeinfo](#getaddednodeinfo)**, **[getconnectioncount](#getconnectioncount)**, **[getnettotals](#getnettotals)**, **[getnetworkinfo](#getnetworkinfo)**, **[getnodeaddresses](#getnodeaddresses)**, **[getpeerinfo](#getpeerinfo)**, **[listbanned](#listbanned)**, **[ping](#ping)**, **[setban](#setban)**, **[setnetworkactive](#setnetworkactive)**


### addnode
-----
### clearbanned
-----
### disconnectnode
-----
### getaddednodeinfo
-----
### getconnectioncount
-----
### getnettotals
-----
### getnetworkinfo
-----
### getnodeaddresses
-----
### getpeerinfo
-----
### listbanned
-----
### ping
-----
### setban
-----
### setnetworkactive
-----


RAWTRANSACTIONS
-----
**[analyzepsbt](#analyzepsbt)**, **[combinepsbt](#combinepsbt)**, **[combinerawtransaction](#combinerawtransaction)**, **[converttopsbt](#converttopsbt)**, **[createpsbt](#createpsbt)**, **[createrawtransaction](#createrawtransaction)**, **[decodepsbt](#decodepsbt)**, **[decoderawtransaction](#decoderawtransaction)**, **[decodescript](#decodescript)**, **[finalizepsbt](#finalizepsbt)**, **[fundrawtransaction](#fundrawtransaction)**, **[getrawtransaction](#getrawtransaction)**, **[joinpsbts](#joinpsbts)**, **[sendrawtransaction](#sendrawtransaction)**, **[signrawtransactionwithkey](#signrawtransactionwithkey)**, **[testmempoolaccept](#testmempoolaccept)**, **[utxoupdatepsbt](#utxoupdatepsbt)**


### analyzepsbt
-----
### combinepsbt
-----
### combinerawtransaction
-----
### converttopsbt
-----
### createpsbt
-----
### createrawtransaction
-----
### decodepsbt
-----
### decoderawtransaction
-----
### decodescript
-----
### finalizepsbt
-----
### fundrawtransaction
-----
### getrawtransaction
-----
### joinpsbts
-----
### sendrawtransaction
-----
### signrawtransactionwithkey
-----
### testmempoolaccept
-----
### utxoupdatepsbt
-----


UTIL
-----
**[createmultisig](#createmultisig)**, **[deriveaddresses](#deriveaddresses)**, **[estimatesmartfee](#estimatesmartfee)**, **[getdescriptorinfo](#getdescriptorinfo)**, **[signmessagewithprivkey](#signmessagewithprivkey)**, **[validateaddress](#validateaddress)**, **[verifymessage](#verifymessage)**


### createmultisig
-----
### deriveaddresses
-----
### estimatesmartfee
-----
### getdescriptorinfo
-----
### signmessagewithprivkey
-----
### validateaddress
-----
### verifymessage
-----


WALLET
-----
**[abandontransaction](#abandontransaction)**, **[abortrescan](#abortrescan)**, **[addmultisigaddress](#addmultisigaddress)**, **[backupwallet](#backupwallet)**,  **[bumpfee](#bumpfee)**,  **[createwallet](#createwallet)**,  **[dumpprivkey](#dumpprivkey)**,  **[dumpwallet](#dumpwallet)**,  **[encryptwallet](#encryptwallet)**,  **[getaddressesbylabel](#getaddressesbylabel)**,  **[getaddressinfo](#getaddressinfo)**,  **[getbalance](#getbalance)**,  **[getbalances](#getbalances)**,  **[getnewaddress](#getnewaddress)**,  **[getrawchangeaddress](#getrawchangeaddress)**,  **[getreceivedbyaddress](#getreceivedbyaddress)**,  **[getreceivedbylabel](#getreceivedbylabel)**,  **[gettransaction](#gettransaction)**,  **[getunconfirmedbalance](#getunconfirmedbalance)**,  **[getwalletinfo](#getwalletinfo)**,  **[importaddress](#importaddress)**,  **[importmulti](#importmulti)**,  **[importprivkey](#importprivkey)**,  **[importprunedfunds](#importprunedfunds)**,  **[importpubkey](#importpubkey)**,  **[importwallet](#importwallet)**,  **[keypoolrefill](#keypoolrefill)**,  **[listaddressgroupings](#listaddressgroupings)**,  **[listlabels](#listlabels)**,  **[listlockunspent](#listlockunspent)**,  **[listreceivedbyaddress](#listreceivedbyaddress)**,  **[listreceivedbylabel](#listreceivedbylabel)**,  **[listsinceblock](#listsinceblock)**,  **[listtransactions](#listtransactions)**,  **[listunspent](#listunspent)**,  **[listwalletdir](#listwalletdir)**,  **[listwallets](#listwallets)**,  **[loadwallet](#loadwallet)**,  **[lockunspent](#lockunspent)**,  **[removeprunedfunds](#removeprunedfunds)**,  **[rescanblockchain](#rescanblockchain)**,  **[sendmany](#sendmany)**,  **[sendtoaddress](#sendtoaddress)**,  **[sethdseed](#sethdseed)**,  **[setlabel](#setlabel)**,  **[settxfee](#settxfee)**,  **[setwalletflag](#setwalletflag)**,  **[signmessage](#signmessage)**,  **[signrawtransactionwithwallet](#signrawtransactionwithwallet)**,  **[unloadwallet](#unloadwallet)**,  **[walletcreatefundedpsbt](#walletcreatefundedpsbt)**,  **[walletlock](#walletlock)**,  **[walletpassphrase](#walletpassphrase)**,  **[walletpassphrasechange](#walletpassphrasechange)**,  **[walletprocesspsbt](#walletprocesspsbt)**


### abandontransaction
-----
### abortrescan
-----
### addmultisigaddress
-----
### backupwallet
-----
### bumpfee
-----
### createwallet
-----
### dumpprivkey
-----
### dumpwallet
-----
### encryptwallet
-----
### getaddressesbylabel
-----
### getaddressinfo
-----
### getbalance
-----
### getbalances
-----
### getnewaddress
-----
### getrawchangeaddress
-----
### getreceivedbyaddress
-----
### getreceivedbylabel
-----
### gettransaction
-----
### getunconfirmedbalance
-----
### getwalletinfo
-----
### importaddress
-----
### importmulti
-----
### importprivkey
-----
### importprunedfunds
-----
### importpubkey
-----
### importwallet
-----
### keypoolrefill
-----
### listaddressgroupings
-----
### listlabels
-----
### listlockunspent
-----
### listreceivedbyaddress
-----
### listreceivedbylabel
-----
### listsinceblock
-----
### listtransactions
-----
### listunspent
-----
### listwalletdir
-----
### listwallets
-----
### loadwallet
-----
### lockunspent
-----
### removeprunedfunds
-----
### rescanblockchain
-----
### sendmany
-----
### sendtoaddress
-----
### sethdseed
-----
### setlabel
-----
### settxfee
-----
### setwalletflag
-----
### signmessage
-----
### signrawtransactionwithwallet
-----
### unloadwallet
-----
### walletcreatefundedpsbt
-----
### walletlock
-----
### walletpassphrase
-----
### walletpassphrasechange
-----
### walletprocesspsbt
-----







ZMQ
-----
**[getzmqnotifications](#getzmqnotifications)**


### getzmqnotifications
-----


