namespace ProjectGSM
{
    using System;
    using System.Text;

    public enum Type
    {
        LiIon, NiMH, NiCd, LiPoly
    }

    public class Battery
    {
        private const string DefaultModel = "SomeModel";
        private const uint DefaultHoursTalk = 100;
        private const uint DefaultHoursIdle = 100;
        private const Type DefaultBatteryType = Type.LiIon;

        private string batteryModel;
        private uint hoursIdle;
        private uint hoursTalk;
        private Type batteryType;

        public Battery()
            : this(DefaultModel, DefaultHoursIdle, DefaultHoursTalk, DefaultBatteryType)
        {
        }

        public Battery(string batteryModel, uint hoursIdle, uint hoursTalk, Type batteryType)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery model can NOT be null or empty!");
                }

                this.batteryModel = value;
            }
        }

        public uint HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours of talk time must be > 0!");
                }

                this.hoursTalk = value;
            }
        }

        public uint HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours of talk time must be > 0!");
                }

                this.hoursIdle = value;
            }
        }

        public Type BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Battery Specifications : Model - {1} , Type - {0} ," +
                            " Talk time - {2} , Idle time - {3}",
                            this.BatteryType,
                            this.BatteryModel,
                            this.HoursTalk,
                            this.HoursIdle);
            return sb.ToString();
        }
    }
}
