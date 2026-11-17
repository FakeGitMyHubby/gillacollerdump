using System.Runtime.InteropServices;

namespace Fusion;

public interface ISceneLoadDone : _0021_00210
{
	void SceneLoadDone([In] ref SceneLoadDoneArgs sceneInfo);
}
