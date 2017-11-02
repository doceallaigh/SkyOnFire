using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Standalone.Interfaces
{
    interface IActionSelector
    {
        /// Concept:
        /// Given concrete start state s
        /// Given a collection of force vectors F with components denoted Fi with weights W with components denoted wi
        /// Given a cost function C : F -> float
        /// select W such that C(WF) is minimized
        /// Given actuator model A acting in continuous space in dimensions:
        ///    x, y, z
        ///    roll, pitch, yaw
        ///    v_x, v_y, v_z
        ///    v_roll, v_pitch, v_yaw
        /// Return parameterized aggregate action a which minimizes [C]
        /// 
        /// Note that: C(w1F1,w2F2) != C(w1F1,0F2) + C(0F1,w2F2)
        /// 
        /// First level approximation:
        /// Select W' among all combinations of W comprised of values from 0 to [F] which minimizes C(W'F)
        /// (Future step, apply genetic algorithm to find local minima)
        /// Select scalar multiplier s which minimizes C(sW'F)
        /// return sW'F
        void PlaceHolder();
    }
}
