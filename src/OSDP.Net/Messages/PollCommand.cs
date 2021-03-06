using System.Collections.Generic;

namespace OSDP.Net.Messages
{
    internal class PollCommand : Command
    {
        public PollCommand(byte address)
        {
            Address = address;
        }

        protected override byte CommandCode => 0x60;

        protected override IEnumerable<byte> SecurityControlBlock()
        {
            return new byte[]
            {
                0x02,
                0x15
            };
        }

        protected override IEnumerable<byte> Data()
        {
            return new byte[] { };
        }

        protected override void CustomCommandUpdate(List<byte> commandBuffer)
        {
            
        }
    }
}