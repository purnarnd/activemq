//
// Marshalling code for Open Wire Format for BrokerId
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using System;
using System.Collections;

using OpenWire.Core;

namespace OpenWire.Core.Commands
{
    public class BrokerId : AbstractCommand
    {
        string brokerId;



        // TODO generate Equals method
        // TODO generate GetHashCode method
        // TODO generate ToString method


        public override int GetCommandType() {
            return 1;
        }


        // Properties

        public string BrokerIdValue
        {
            get
            {
                return brokerId;
            }
            set
            {
                brokerId = value;
            }            
        }

    }
}
