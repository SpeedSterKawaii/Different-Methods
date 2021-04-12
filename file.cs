public void Execute(string method, string script)
{
    if (method == "Wrapper") // They are choosing wrapper
    {
        //  Execute via "Wrapper Pipe"
    }
    else if (method == "Bytecode")
    {
        //  Execute via "Bytecode Pipe"
    }
    else if (string.IsNullOrEmpty(method))
    {
        // This is a empty string.
        MessageBox.Show("String throwed NullOrEmpty Exception.","Method");
    }
    else
    {
        /*
            Not a method and cannot continue.
        */
        MessageBox.Show("This is not a method.","Method");
    }
}

// Might not be correct due to me making this in vs studio.

// Proof
https://cdn.discordapp.com/attachments/823254755144630282/831172898768814170/unknown.png
