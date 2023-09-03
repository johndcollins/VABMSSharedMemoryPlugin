using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Common.MacroProgramming
{
    [Serializable]
    [XmlInclude(typeof(AnalogSignal))]
    [XmlInclude(typeof(DigitalSignal))]
    [XmlInclude(typeof(TextSignal))]
    public abstract class Signal
    {
        [NonSerialized] private object _publisherObject;
        [NonSerialized] private object _source;
        [NonSerialized] private object _subSource;
        public string Category { get; set; }
        public string CollectionName { get; set; }
        public string FriendlyName { get; set; }
        public virtual bool HasListeners { get; }
        public string Id { get; set; }

        public int? Index { get; set; }

        [XmlIgnore]
        public object PublisherObject
        {
            get => _publisherObject;
            set => _publisherObject = value;
        }

        public abstract string SignalType { get; }

        /// <summary>
        ///     The source or device that this signal emanates from
        /// </summary>
        [XmlIgnore]
        public object Source
        {
            get => _source;
            set => _source = value;
        }

        public string SourceAddress { get; set; }
        public string SourceFriendlyName { get; set; }
        public string SubcollectionName { get; set; }

        [XmlIgnore]
        public object SubSource
        {
            get => _subSource;
            set => _subSource = value;
        }

        public string SubSourceAddress { get; set; }

        public string SubSourceFriendlyName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            return GetHashCode() == obj.GetHashCode() && Util.DeepEquals(this, obj);
        }

        public override int GetHashCode()
        {
            return Util.ToRawBytes(this).GetHashCode();
        }

        public override string ToString()
        {
            return Util.SerializeToXml(this, typeof(Signal));
        }
    }
}