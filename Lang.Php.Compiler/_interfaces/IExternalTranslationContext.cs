﻿using Lang.Cs.Compiler;
using Lang.Php.Compiler.Translator;
using System;

namespace Lang.Php.Compiler
{
    public interface IExternalTranslationContext
    {
        IPhpValue TranslateValue(IValue srcValue);
        TranslationInfo GetTranslationInfo();

        ClassReplaceInfo FindOneClassReplacer(Type srcType);

        Version PhpVersion { get; }
    }
}
