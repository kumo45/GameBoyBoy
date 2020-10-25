using System.ComponentModel;

namespace GBLib.Architecture.Implementations.Memory
{
    public static class MemoryMap
    {
        public static byte[] Memory = new byte[0x1FFF];

        /// <summary>
        ///0000-3FFF   16KB ROM Bank 00     (in cartridge, fixed at bank 00)
        /// </summary>
        public static AdressRange RomBank00 = new AdressRange { Start = 0x0000, End = 0x3FFF };

        /// <summary>
        ///4000 - 7FFF   16KB ROM Bank 01..NN(in cartridge, switchable bank number)
        /// </summary>
        public static AdressRange RomBank01NN = new AdressRange { Start = 0x4000, End = 0x7FFF };

        /// <summary>
        ///8000 - 9FFF   8KB Video RAM(VRAM)(switchable bank 0 - 1 in CGB Mode)
        /// </summary>
        public static AdressRange VRam = new AdressRange { Start = 0x8000, End = 0x3FFF };

        /// <summary>
        ///A000 - BFFF   8KB External RAM(in cartridge, switchable bank, if any)
        /// </summary>
        public static AdressRange ExternalRam = new AdressRange { Start = 0xA000, End = 0xBFFF };

        /// <summary>
        ///C000 - CFFF   4KB Work RAM Bank 0(WRAM)
        /// </summary>
        public static AdressRange WorkRam0 = new AdressRange { Start = 0xC000, End = 0xCFFF };

        /// <summary>
        ///D000 - DFFF   4KB Work RAM Bank 1(WRAM) (switchable bank 1 - 7 in CGB Mode)
        /// </summary>
        public static AdressRange WorkRam1 = new AdressRange { Start = 0xD000, End = 0xDFFF };

        /// <summary>
        ///E000 - FDFF   Same as C000 - DDFF(ECHO)(typically not used)
        /// </summary>
        public static AdressRange Echo = new AdressRange { Start = 0xE000, End = 0xFDFF };

        /// <summary>
        ///FE00 - FE9F   Sprite Attribute Table(OAM)
        /// </summary>
        public static AdressRange Oam = new AdressRange { Start = 0xFE00, End = 0xFE9F };
        
        /// <summary>
        ///FEA0 - FEFF   Not Usable
        /// </summary>
        public static AdressRange NotUsable = new AdressRange { Start = 0xFEA0, End = 0xFEFF };

        /// <summary>
        ///FF00 - FF7F   I / O Ports
        /// </summary>
        public static AdressRange IOPorts = new AdressRange { Start = 0xFF00, End = 0xFF7F };

        /// <summary>
        ///FF80 - FFFE High RAM(HRAM)
        /// </summary>
        public static AdressRange HRam = new AdressRange { Start = 0xFF80, End = 0xFFFE };

        /// <summary>
        ///FFFF        Interrupt Enable Register
        /// </summary>
        public static AdressRange Interrupt = new AdressRange { Start = 0xFFFF, End = 0xFFFF };

        /// <summary>
        /// 0100-014F contains the cartridge header.
        /// </summary>
        public static AdressRange CartridgeHeader = new AdressRange { Start = 0x0100, End = 0x014F };
    }
}
