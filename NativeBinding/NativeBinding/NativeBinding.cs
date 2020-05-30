using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftLiu.NativeBinding
{
    public class NativeBinding
    {
        private static readonly INativeImplementation m_implementation = null;

        public static INativeImplementation Instance { get { return m_implementation; } }

        private NativeBinding()
        {

        }

        static NativeBinding()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            m_implementation = new NativeImplementationAndroid();
#elif UNITY_IOS && !UNITY_EDITOR
            m_implementation = new NativeImplementationIOS();
#else
            m_implementation = new NativeImplementationEditor();
#endif
        }
    }
}
