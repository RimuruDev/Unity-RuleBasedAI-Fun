using RimuruDev.Internal.Codebase.Common.Characters;
using RimuruDev.Internal.Codebase.Common.Services;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Bootstrap
{
    public class Bootstrapper : MonoBehaviour
    {
        private CharactersFactory characterFactory;
        private CharactersRepository charactersRepository;

        private void Start()
        {
            charactersRepository = new CharactersRepository();
            characterFactory = new CharactersFactory(charactersRepository);

            characterFactory.Create();
        }

        [NaughtyAttributes.Button]
        private void CreateCharacter()
        {
            characterFactory.Create();
        }
    }
}