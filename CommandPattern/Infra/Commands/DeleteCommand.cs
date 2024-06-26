﻿using CommandPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Infra.Commands
{
    public class DeleteCommand : Command
    {
        private string key;
        public DeleteCommand(string key, DataReceiver dataReceiver) : base(dataReceiver)
        {
            this.key = key;
        }
        public override void Execute()
        {
            _receiver.Delete(key);
        }
    }
}
