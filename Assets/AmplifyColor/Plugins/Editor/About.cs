// Amplify Color - Advanced Color Grading for Unity
// Copyright (c) Amplify Creations, Lda <info@amplify.pt>

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace AmplifyColor
{
	public class About : EditorWindow
	{
		private const string AboutImageGUID = "ab75e8f12bda12c46a2124ff051a96cb";
		private Vector2 m_scrollPosition = Vector2.zero;
		private Texture2D m_aboutImage;

		[MenuItem( "Window/Amplify Color/About...", false, 22 )]
		static void Init()
		{
			About window = ( About ) EditorWindow.GetWindow( typeof( About ) , true , "About Amplify Color" );
			window.minSize = new Vector2( 502, 290 );
			window.maxSize = new Vector2( 502, 290 );
			window.Show();
		}

		public void OnFocus()
		{
			if ( m_aboutImage == null )
			{
				m_aboutImage = AssetDatabase.LoadAssetAtPath( AssetDatabase.GUIDToAssetPath( AboutImageGUID ), typeof( Texture2D ) ) as Texture2D;
			}
		}

		public void OnGUI()
		{
			m_scrollPosition = GUILayout.BeginScrollView( m_scrollPosition );

			GUILayout.BeginVertical();

			GUILayout.Space( 10 );

			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.Box( m_aboutImage, GUIStyle.none );

			if ( Event.current.type == EventType.MouseUp && GUILayoutUtility.GetLastRect().Contains( Event.current.mousePosition ) )
				Application.OpenURL( "https://www.amplify.pt" );

			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();

			GUIStyle labelStyle = new GUIStyle( EditorStyles.label );
			labelStyle.alignment = TextAnchor.MiddleCenter;
			labelStyle.wordWrap = true;

			GUILayout.Label( "\nAmplify Color " + VersionInfo.StaticToString(), labelStyle, GUILayout.ExpandWidth( true ) );

			GUILayout.Label( "\nCopyright (c) Amplify Creations, Lda. All rights reserved.\n", labelStyle, GUILayout.ExpandWidth( true ) );

			GUILayout.EndVertical();

			GUILayout.EndScrollView();
		}
	}
}
