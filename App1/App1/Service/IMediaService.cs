using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App1
{
	public interface IMediaService
	{
		  Task OpenGallery();
		  void ClearFiles(List<string> filePaths);
	}
}
