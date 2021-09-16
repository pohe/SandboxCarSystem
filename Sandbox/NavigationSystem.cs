using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class NavigationSystem
    {
        #region Instancefields
        private string _systemName;
        private string _systemVersion;
        //private double _destLatitude;
        //private double _destLongitude;
        //private double _curLatitude;
        //private double _curLongitude;
        //private double _lastLatitude;
        //private double _lastLongitude;
        //private double Speed;

        #endregion

        #region Constructor
        public NavigationSystem()
        {
            _systemName = "DummyNavigator 1.0";
            _systemVersion = "1.0";
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _systemName; }
        }

        public string Version
        {
            get { return _systemVersion; }
        }
        #endregion

        #region Methods
        public void UpdateSystem(string NewVersion, string NewName)
        {
            // ooga booga
            _systemVersion = NewVersion;
            _systemName = NewName;
            // where da update data at
        }
        #endregion
    }
}
