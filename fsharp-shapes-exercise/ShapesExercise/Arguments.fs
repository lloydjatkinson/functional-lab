module Arguments
    open CommandLine
    type options =
        { [<Option('r', "read", Required = true, HelpText = "Input files.")>] files : seq<string>;
          [<Option(HelpText = "Prints all messages to standard output.")>] verbose : bool;
          [<Value(0, MetaName="offset", HelpText = "File offset.")>] offset : int64 option; }
