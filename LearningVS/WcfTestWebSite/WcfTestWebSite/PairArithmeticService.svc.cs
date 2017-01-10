using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestWebSite
{

    [DataContract]
    public class Pair
    {
        int m_first;
        int m_second;

        public Pair()
        {
            m_first = 0;
            m_second = 0;
        }

        public Pair(int first, int second)
        {
            m_first = first;
            m_second = second;
        }

        [DataMember]
        public int First
        {
            get { return m_first; }
            set { m_first = value; }
        }

        [DataMember]
        public int Second
        {
            get { return m_second; }
            set { m_second = value; }
        }

    }


    [ServiceContract]
    public interface IPairArithmeticService
    {
        [OperationContract]
        Pair Add(Pair p1, Pair p2);

        [OperationContract]
        Pair Subtract(Pair p1, Pair p2);
    }

    public class PairArithmeticService : IPairArithmeticService
    {
        Pair IPairArithmeticService.Add(Pair p1, Pair p2)
        {
            Pair result = new Pair();

            result.First = p1.First + p2.First;
            result.Second = p1.Second + p2.Second;

            return result;
        }

        Pair IPairArithmeticService.Subtract(Pair p1, Pair p2)
        {
            Pair result = new Pair();

            result.First = p1.First - p2.First;
            result.Second = p1.Second - p2.Second;

            return result;
        }
    }

}
