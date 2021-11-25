using System.Collections;

namespace GBLib.Architecture.Implementations.Memory
{
    public class Registers
    {
        /// <summary>
        /// Accumulator
        /// </summary>
        public BitArray A;

        /// <summary>
        /// Flags:
        /// 7: Z - Zero
        /// 6: N - Set by subtraction
        /// 5: H - Half-carry - set if carrying to or borrowing from bit 3
        /// 4: CY - Carry - set if carrying from/borrowing to bit 7 
        /// </summary>
        public BitArray F;

        /// <summary>
        /// Auxiliary
        /// </summary>
        public BitArray B;
        /// <summary>
        /// Auxiliary
        /// </summary>
        public BitArray C;

        /// <summary>
        /// Auxiliary
        /// </summary>
        public BitArray D;
        /// <summary>
        /// Auxiliary
        /// </summary>
        public BitArray E;

        /// <summary>
        /// Auxiliary
        /// </summary>
        public BitArray H;
        /// <summary>
        /// Auxiliary
        /// </summary>
        public BitArray L;

        /// <summary>
        /// Program counter - address data of the next instruction
        /// </summary>
        public BitArray PC;
        public BitArray SP;

        public Registers()
        {
            A = new BitArray(8);
            F = new BitArray(8);
            B = new BitArray(8);
            C = new BitArray(8);
            D = new BitArray(8);
            E = new BitArray(8);
            H = new BitArray(8);
            L = new BitArray(8);
            PC = new BitArray(16);
            SP = new BitArray(16);
        }

        public BitArray GetRegister()
    }
}
