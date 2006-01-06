//
// Marshalling code for Open Wire Format for IntegerResponse
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
    public class IntegerResponse : AbstractCommand
    {
        int result;



        // TODO generate Equals method
        // TODO generate GetHashCode method
        // TODO generate ToString method


        public override int GetCommandType() {
            return 1;
        }


        // Properties

        public int Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }            
        }

    }
}
