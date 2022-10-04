using System.Numerics;

namespace OpenFOAM.Physics.Atmospher;

public class ObukhovLength
{
        /// <summary>
        ///  Name of velocity field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the output field for ObukhovLength
        /// </summary>
        public string ResultName { get; set; }

        /// <summary>
        /// Name of the output field for Ustar
        /// </summary>
        public string UstarResultName { get; set; }

        /// <summary>
        /// Reference density (to convert from kinematic to static pressure)
        /// </summary>
        public INumber<float> RhoRef;

        //- von Kármán constant [-]
        private float _kappa;  //TODO add static type with constants

        //- Thermal expansion coefficient [1/K]
        private float _beta;  //TODO add static type with constants

        /// <summary>
        ///  Gravitational acceleration vector [m/s2]
        /// </summary>
        private readonly Vector3 g; //TODO add static type with constants

        /// <summary>
        /// Hard-coded Obukhov length field and friction velocity
        /// </summary>
        /// <returns>true if fields did not previously exist</returns>
        bool CalculateObukhovLength()
        {
            throw new NotImplementedException();
        }

        //- Remove (checkOut) the output fields from the object registry
        public void RemoveObukhovLength()
        {}

        //- Read the data
        public bool Read(Dictionary<int,int> dict)
        {
            
        }

        //- Calculate the output fields
        public bool Execute()
        {
            
        }

        //- Write the output fields
        public bool Write()
        {
            
        }

        //- Update for changes of mesh
        public void UpdateMesh(mapPolyMesh mpm)
        {
            
        }

        //- Update for mesh point-motion
        public void MovePoints(polyMesh m)
        {
            
        }
}